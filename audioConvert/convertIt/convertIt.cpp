// convertIt.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

//using namespace std;

class digAu
{
	//somewhat self explanatory objects
	TagLib::FileRef *f;
	TagLib::Tag *tag;
	std::string name;
	std::string rename;
	std::string ext;
	int format;
	
	std::string getProperty(std::string); //grabs some property determined by the string
	void addS(std::string s){ rename += s; } //adds s to rename
	void init(char*, int); //initializer
public:
	digAu(){}; //default constructor. Never used, but I should give it something to do
	digAu(char* c, int i){ init(c, i); }; //char* constructor
	digAu(std::string s, int i){ init((char*)s.c_str(), i); } //string constructor
	void addProperty(std::string); //calls addS(getProperty(thisString))
	void save(); //creates directories if needed, reads the input file and saves some new stuff
	void toWAV(); //creates a wav file. not used
	void toMP3(); //does nothing. meant to use liblame and read toWAV's output
};

std::string formatDelimit(char*&); //returns a string where tags are removed
									//and everything is delimited by a |

int main(int argc, char* argv[])
{
	if (argc <=4 ) return -1; //file names are in the 5th+ index as you can see here. could cout something instead
	//[1] output path or same dir
	//[2] selected codec
	//[3] codec options
	//[4] name format
	//[5-argc] input files

	//for storing argv cotents in a more sensible manner
	int codec;	
	std::deque<double> codecOpt;
	std::deque<std::string> formatOpt, inputFs;

	formatOpt.push_back(argv[1]); //output path gets added to "name format"
	codec = std::atoi(argv[2]); //encoder is an int
	
	std::stringstream ss; //temporary location for easy stream reading
	ss << argv[3]; //grab encoder options (even though there are none). Expected to be a massive 
	//string with spaces

	double dTemp; 
	while (ss >> dTemp) codecOpt.push_back(dTemp); //store each encoder option in a seperate index

	ss.clear(); //clear eof flag
	
	ss << formatDelimit(argv[4]); //delimit name format and put it in the stringstream

	char sTemp[30]; //what are the chances of a title or album being more than 31 characters?
	while (ss.getline(sTemp, 30, '|')) formatOpt.push_back(sTemp); //read up to | and store in a new index

	for (int i = 5; i < argc; i++) inputFs.push_back(argv[i]); //index 5 holds the first file name
	//stores all the file names in a deque

	//All info is collected. Now for some work

	//test. It looks nice so I'm leaving it here
	std::cout << "Output directory: " << (formatOpt[0].length()>0 ? formatOpt[0] : "[Same as File]") << std::endl
		<< "Selected codec: " << codec << std::endl
		<< "Codec options..." << std::endl;

	for (unsigned int i = 0; i < codecOpt.size(); i++)std::cout << i << ") " << codecOpt[i] << std::endl;

	std::cout << "Format options" << std::endl;
	for (unsigned int i = 0; i < formatOpt.size(); i++)std::cout << formatOpt[i].length() << ") " << formatOpt[i] << std::endl;
	//end test

	//for each inpt file
	for (unsigned int i = 0; i < inputFs.size(); i++)
	{
		//display the current file 
		std::cout << "\nWorking with "<<inputFs[i] << std::endl;

		digAu dio(inputFs[i], codec); //create a digAu which will handle the rest
		for (int j = 0; j < formatOpt.size(); j++) dio.addProperty(formatOpt[j]); //stores the new name
		dio.save(); //does all the dirty work
	}
	system("pause");
	return 0;
}

void digAu::init(char *s, int pcm)//initializer
{
	f = new TagLib::FileRef(s); //opens the input file for stuff
	if (!(*f).isNull() && (*f).tag()) tag = f->tag(); //FileRef.tag returns something.
													//A pointer to tags, maybe

	rename = "";
	name = s;

	//I'm not to sure about Flac, but wav and ogg I think work
	if (pcm == 1)
	{
		format = SF_FORMAT_FLAC | SF_FORMAT_PCM_24;
		ext = ".flac";
	}
	else if (pcm == 2)
	{
		format = SF_FORMAT_OGG | SF_FORMAT_VORBIS;
		ext = ".ogg";
	}
	else
	{
		format = SF_FORMAT_WAV | SF_FORMAT_PCM_16;
		ext = ".wav";
	}
}

std::string digAu::getProperty(std::string s)
{
	//checks if s matches one of these strings. toUpper because some s's could be all caps, no caps,
	//or regular
		//if it matches one, return that tag text
	if (std::strcmp((char*)toUpper(s).c_str(), "ALBUM") == 0)
		return tag->album().toCString();
	else if (std::strcmp((char*)toUpper(s).c_str(), "ARTIST") == 0)
		return tag->artist().toCString();
	else if (std::strcmp((char*)toUpper(s).c_str(), "TITLE") == 0)
		return tag->title().toCString();
	else if (std::strcmp((char*)toUpper(s).c_str(), "GENRE") == 0)
		return tag->genre().toCString();
	else if (std::strcmp((char*)s.c_str(), "year") == 0)
		return static_cast<std::ostringstream*>(&(std::ostringstream() << tag->year()))->str();//idk
	else if (s[0] == ' ') //if there are spaces, just return spaces...could be handled by else..
		return std::string(s.length(), ' ');
	else if (s[0] == '#') //for #, get track # and left pad with 0s if needed
	{
		std::stringstream ss;
		ss << std::setfill('0') << std::setw(s.length()) << tag->track();
		return ss.str();
	}
	else return s; //if none of these cases, return the string
}

void digAu::addProperty(std::string s)
{
	//compare string to it's upper or lowercase self. if so, send addS the tag in upper or lowercase
	//else, just send addS the tag
	if (std::strcmp((char*)toUpper(s).c_str(), (char*)s.c_str()) == 0)
		addS(toUpper(getProperty(s)));
	else if (std::strcmp((char*)toLower(s).c_str(), (char*)s.c_str()) == 0)
		addS(toLower(getProperty(s)));
	else addS(getProperty(s));
}

void digAu::save()
{
	//add an extension to the new file name
	rename += ext;

	//using the boost library create a path object
	boost::filesystem::path path_file(rename);
	if (path_file.has_parent_path()) //if the path has a parent directory
	{
		path_file = path_file.parent_path(); //work with the parent directory
		if (!boost::filesystem::exists(path_file)) //if this path doesn't exist
			boost::filesystem::create_directories(path_file); //create it
	}

	SNDFILE		*infile, *outWav;
	SF_INFO		sinfo;

	infile = sf_open((char*)name.c_str(), SFM_READ, &sinfo); //open SNDFILE for reading. don't know 
															//what sinfo is needed for
	sinfo.format = format; //give SF_INFO.format the fancy int that was initialized in init
	outWav = sf_open((char*)rename.c_str(), SFM_WRITE, &sinfo); //open SNDFILE for writing. Still don't
															//know what sinfo is needed for

	sf_count_t x; //compiler complained when this was an int.
	const int buf_l = 4096;
	static float buf[buf_l];
	//what if...for 4096 floats, there's silence?
	while ((x = sf_read_float(infile, buf, buf_l)) > 0) sf_write_float(outWav, buf, x);
	//read some chunk of data and write it to the output file. Somehow in a new format

	//close the files. The magic is done
	sf_close(infile);
	sf_close(outWav);

	/*
	//doesn't transfer track info. Failed attempt to copy the info.
	TagLib::FileRef *n = new TagLib::FileRef((char*)rename.c_str());
	TagLib::Tag *tag2;
	tag2 = n->tag();

	tag2->setAlbum(tag->album());
	tag2->setArtist(tag->artist());
	tag2->setTrack(tag->track());
	tag2->setYear(tag->year());
	tag2->setGenre(tag->genre());
	tag2->setTitle(tag->title());

	n->save();
	*/
	//toWAV();
	//toMP3();

	std::cout << "done!\n";
}

void digAu::toWAV()
{
	/*
	//similar to save()
	SNDFILE		*infile, *outWav;
	SF_INFO		sinfo;

	infile = sf_open((char*)name.c_str(), SFM_READ, &sinfo);
	sinfo.format = SF_FORMAT_WAV | SF_FORMAT_PCM_16;
	outWav = sf_open("temp.wav", SFM_WRITE, &sinfo);

	sf_count_t x;
	const int buf_l = 4096;
	static float buf[buf_l];
	while ((x = sf_read_float(infile, buf, buf_l)) > 0) sf_write_float(outWav, buf, x);

	sf_close(infile);
	sf_close(outWav);
	*/
}

void digAu::toMP3()
{
	//use liblame to read temp.wav and store an mp3
}


std::string formatDelimit(char* &s)
{
	//I need the string.length() so move s to txt, and use t as a storage place
	std::string txt = s, t = "";
	for (int i = 0; i < txt.length(); i++)
	{
		//read this char
		//if it's < put all the following chars until > in t
		if (txt[i] == '<') while (txt[++i] != '>') t += txt[i];
		//else if it's space, put this and all following spaces up to a non-space in t
		else if (txt[i] == ' ') while (txt[i] == ' ') t += txt[i++];
		//else if it's #, same as space but with #
		else if (txt[i] == '#') while (txt[i] == '#') t += txt[i++];
		//else if it's a > skip to the end of this iteration. this fixes a slight error in if(<)
		else if(txt[i] == '>') continue;
		//if none of these, just put this character in t and increment
		else t += txt[i++];
		//decrement because all the ifs increment too much
		i--;
		//and place a | at the end of each string
		t += '|';
	}
	return t;
}