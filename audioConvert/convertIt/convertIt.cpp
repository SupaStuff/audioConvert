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
		std::cout << "********************************\n";
		tag = (*f).tag();
	}
	rename = "";
	name = s;
}

std::string digAu::getProperty(std::string s)
{

	std::cout << "you are here"; 
		std::cout << "getting " << s << std::endl;
		std::cout << "title ";
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
	std::cout << "\nadding " << s<<std::endl;
	if (std::strcmp((char*)toUpper(s).c_str(), (char*)s.c_str())) addS(toUpper(getProperty(s)));
	else if (std::strcmp((char*)toLower(s).c_str(), (char*)s.c_str())) addS(toLower(getProperty(s)));
	else addS(getProperty(s));
	std::cout << "done\n";
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
		digAu dio(inputFs[i]);
		for (int j = 0; j < formatOpt.size(); i++) 
		{
			std::cout << formatOpt[j];
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


