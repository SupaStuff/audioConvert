audioConvert
============

Honors Project. Inspired by Winamp's Format Converter

TODO:

  add libvorbis, lame, and flac
  
  add some aac lc encoder
  
  create a property editer
  
  use discogs api for retrieving more information
  
  
  fix "Release Mode"
  
  ...fix ridiculous dependencies

USAGE:

  Written in Visual Studio 2013.
  
  To debug:
    
	Install these libraries in this order:
      
	  zlib: http://www.zlib.net/
      
	  taglib: http://taglib.github.io/
	  
	  libsndfile: http://www.mega-nerd.com/libsndfile/
	Follow these instructions for each individually:
    
	Use cmake (I used the gui) to build them. http://www.cmake.org/
	
	Source and build paths are the same. It's the folder with all the stuff in it. 
	
	Check advanced, and click configure.
	
	Use native compiler and pick Visual Studio 12. OK.
	
	ENABLE_STATIC and ENABLE_STATIC_RUNTIME need to be checked. Click generate.
	
	Then, open the generated .sln file.
	
	In Release mode, build zlib and in Debug mode build taglib and libsndfile.
	
	Right click ALL_BUILD and build, then Right click INSTALL and build.
    
    Now everything in my project should be ready to compile. If it isn't, that's too bad...
  
  To Release:
    
	It doesn't work.

v2

  fixed the taglib problem. For now it only converts between lossless formats(wav, flac, and ogg). All the other options do wav for now. The output files don't copy the properties of the input files.

v1
  
  uses taglib for reading the properties. It's broken. It's almost the same as the sample code, but it crashes when retrieving the file properties.
