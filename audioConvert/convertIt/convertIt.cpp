// convertIt.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"


#include <iomanip>
#include <stdio.h>
#include <fstream>

#include "taglib\fileref.h"
#include "taglib\tag.h"
#include "taglib\tpropertymap.h"

using namespace std;

class digAu
{
	TagLib::FileRef *f;
	TagLib::Tag *tag;
	std::string name;
	std::string rename;
	std::string getProperty(std::string);
	void addS(std::string s){ rename += s; }
public:
	digAu(){};
	digAu(char*);
	digAu(std::string s){digAu((char*)s.c_str());}
	void addProperty(std::string s);
	void save();
};

digAu::digAu(char *s)
{
	std::cout << s;
	f = new TagLib::FileRef(s);
	if (!(*f).isNull() && (*f).tag())
	{
		std::cout << "\nSuccessfully initialized. I think...\n";
		tag = f->tag();
	}
	rename = "";
	name = s;
}

std::string digAu::getProperty(std::string s)
{

		std::cout << "getProperty()\n"; 
		//*******************************************************************************
		//(4)crashes at this line. I put this here to see if it was this or my crash ifs
		//*******************************************************************************
		std::cout << tag->title() << std::endl;

		if (std::strcmp((char*)toUpper(s).c_str(), "ALBUM")) return tag->album().toCString();
		else if (std::strcmp((char*)toUpper(s).c_str(), "ARTIST")) return tag->artist().toCString();
		else if (std::strcmp((char*)toUpper(s).c_str(), "TITLE")) return tag->title().toCString();
		else if (std::strcmp((char*)toUpper(s).c_str(), "Genre")) return tag->genre().toCString();
		else if (std::strcmp((char*)s.c_str(), "year")) return static_cast<ostringstream*>(&(ostringstream() << tag->year()))->str();
		else if (s[0] == ' ') return std::string(s.length(), ' ');
		else if (s[0] == '#')
		{
			std::stringstream ss;
			ss << std::setw(s.length()) << std::setfill('0') << tag->track();
			return ss.str();
		}
		else return s;
}

void digAu::addProperty(std::string s)
{
	//**********************************************************************************
	// (3) this is fine, I hope. All the mayhem happens in digAu::getProperty() for now
	//**********************************************************************************
	std::cout << "addProperty()\nchecking the string one more time: " << s <<std::endl;
	if (std::strcmp((char*)toUpper(s).c_str(), (char*)s.c_str())) addS(toUpper(getProperty(s)));
	else if (std::strcmp((char*)toLower(s).c_str(), (char*)s.c_str())) addS(toLower(getProperty(s)));
	else addS(getProperty(s));
	std::cout << "SUCCESS!!!!!!!!!!!!!!!!\n";
}

void digAu::save()
{
	std::ifstream  src(name, std::ios::binary);
	std::ofstream  dst(rename, std::ios::binary);
	std::cout << "copying...\n";
	dst << src.rdbuf();
	std::cout << "done!\n";
	tag->~Tag();
}

std::string formatDelimit(char*&);

//This sample main works if you un comment it and comment mine out.
//The only real difference is that my program has these objects in a class
//and FileRef *f = new FileRef(s);
//But mine crashes when calling the member function for each property
//and the calls are exactly the same

/*
int main(int argc, char *argv[])
{
	for (int i = 5; i < argc; i++) {

		cout << "******************** \"" << argv[i] << "\" ********************" << endl;

		TagLib::FileRef f(argv[i]);

		if (!f.isNull() && f.tag()) {

			TagLib::Tag *tag = f.tag();

			cout << "-- TAG (basic) --" << endl;
			cout << "title   - \"" << tag->title() << "\"" << endl;
			cout << "artist  - \"" << tag->artist() << "\"" << endl;
			cout << "album   - \"" << tag->album() << "\"" << endl;
			cout << "year    - \"" << tag->year() << "\"" << endl;
			cout << "comment - \"" << tag->comment() << "\"" << endl;
			cout << "track   - \"" << tag->track() << "\"" << endl;
			cout << "genre   - \"" << tag->genre() << "\"" << endl;
		}
	}
	system("pause");
	return 0;
}
*/

//My main. I put numbered comments to follow the steps that I think matter.
int main(int argc, char* argv[])
{
	if (argc <=4 ) return -1;
	
	//[1] output path or same dir
	//[2] selected codec
	//[3] codec options
	//[4] name format
	//[5-argc] input files
	int codec;
	std::deque<double> codecOpt;
	std::deque<std::string> formatOpt, inputFs;

	//formatOpt.push_back(argv[1]);
	codec = std::atoi(argv[2]);
	
	std::stringstream ss;
	ss << argv[3];

	double dTemp;
	while (ss >> dTemp) codecOpt.push_back(dTemp);

	ss.clear();

	std::cout << argv[4] <<std::endl<<toUpper(argv[4])<< std::endl << argv[4];
	
	ss << formatDelimit(argv[4]);

	char sTemp[30];
	while (ss.getline(sTemp, 30, '|')) formatOpt.push_back(sTemp);

	for (int i = 5; i < argc; i++) inputFs.push_back(argv[i]);

	//All info is collected. Now for some work

	//test
	std::cout << "Output directory: ?\n" //<< (formatOpt[0].length()>0 ? formatOpt[0] : "[Same as File]") << std::endl
		<< "Selected codec: " << codec << std::endl
		<< "Codec options..." << std::endl;

	for (unsigned int i = 0; i < codecOpt.size(); i++)std::cout << i << ") " << codecOpt[i] << std::endl;

	std::cout << "Format options" << std::endl;
	for (unsigned int i = 0; i < formatOpt.size(); i++)std::cout << formatOpt[i].length() << ") " << formatOpt[i] << std::endl;

	std::cout << "Input files" << std::endl;
	for (unsigned int i = 0; i < inputFs.size(); i++)
	{
		std::cout << i << ") " << inputFs[i] << std::endl;

		//*****************************************************
		// (1) Creates a new digAu using some input file name
	    //*****************************************************
		digAu dio(inputFs[i]);
		for (int j = 0; j < formatOpt.size(); i++) 
		{
			std::cout << "checking the string " << formatOpt[j]<<std::endl;
			//****************************************************************************************
			// (2) Supposed to be iterating through format options to create the new filename string
			//****************************************************************************************
			dio.addProperty(formatOpt[j]);
		}
		dio.save();
	}
	system("pause");
	return 0;
}

std::string formatDelimit(char* &s)
{
	std::string txt = s, t = "";
	std::cout << "txt: " << txt << "\ns: " << s;
	for (int i = 0; i < txt.length(); i++)
	{
		if (txt[i] == '<') while (txt[++i] != '>') t += txt[i];
		else if (txt[i] == ' ') while (txt[i] == ' ') t += txt[i++];
		else if (txt[i] == '#') while (txt[i] == '#') t += txt[i++];
		else if (txt[i] == '\\') t += txt[i++];
		else continue;
		i--;
		t += '|';
	}
	return t;
}


