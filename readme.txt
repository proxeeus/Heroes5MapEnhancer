Heroes of Might & Magic V - Tribes of the East =-= Map Enhancer
===============================================================


1. Purpose / scope
==================

TODO: write.

2. Changelog
============

TODO FOR NEXT SESSION:


Build 10
========

- added namespace MapscriptGen/Scripting: will hold most objects related to the representation of a Script (triggers etc).
- MapscriptGen/Scripting/Script.cs: new datastructure modelling the contents of a script to write into mapscript.lua.
- MapscriptGen/Scripting/Trigger.cs: class generating script triggers.
- MapscriptGen/MapscriptLUAWriter.cs (CreateMapscriptLUAFile()): call writer.WriteLine instead of writer.Write.
- LINQLayer/ArtifactReader.cs (BuildArtifactFromXElement()): fixed a NullReferenceException happening if no CombatScript attributes were found.

Build 9
=======

- MapscriptGen/MapscriptGen.cs (GetMapScript()): finished the base MapScript.xdb detection code.
- MapscriptGen/MapscriptGen.cs (GetMapScript()): moved the first part of the method (recursive calls to get the final subdir) to the Utils class.
- MapscriptGen/MapscriptGen.cs (GetMapScript()): LINQified the method. It takes a whopping 4 lines to get the mapscript.xdb filename now :)
- MapscriptGen/MapscriptGen.cs: renamed GetMapScript into GetMapScriptXDBFromMapFile.
- MapscriptGen/MapscriptGen.cs: renamed CreateMapScript into CreateMapScriptXDBInMapFile.
- MapscriptGen/MapscriptGen.cs: moved GetMapScriptXDBFromMapFile & CreateMapScriptXDBInMapFile to Utils.cs.
- MapscriptGen/MapscriptGen.cs: removed the class.
- MapscriptGen/MapscriptLUAWriter.cs: new class that will write LUA code into mapscript.lua.
- Heroes5MapEnhancer/MapEnhancer.cs: added a new private FileInfo member pointing to the mapscript.xdb file.
- Heroes5MapEnhancer/MapEnhancer.cs: added a new private FileInfo member pointing to the mapscript.lua file.
- Heroes5MapEnhancer/MapEnhancer.cs: added a new private DirectoryInfo member pointing to the final map sub directory (where all the files are located).
- Heroes5MapEnhancer/MapEnhancer.cs (EnhanceMap()): code update with latest objects.
- Heroes5MapEnhancer/MapEnhancer.cs (EnhanceMap()): refactoring of the method into submethods.
- Heroes5MapAPI/Utils.cs: new static class with general-purpose helper methods.
- MapscriptGen/MapscriptXDBReader.cs: new class for reading the mapscript.xdb file in order to get the lua script name.
- MapscriptGen/MapscriptXDBWriter.cs: new class for creating/writing to the mapscript.xdb file if it doesn't already exist.

Build 8
=======

- MapscriptGen/MapscriptGen.cs (GetMapScript()): first pass on the mapscript detection algorithm.

Build 7
=======

- added namespace Heroes5MapAPI.MapscriptGen
- new class MapscriptGen.cs that will generate the LUA map script.

Build 6 (same day as n° 5 but major changes are in)
===================================================

- Say goodbye to the retarded Flavorizator name and say hello to the HOMM V Map Enhancer project!
- Removed / reworked / rewrote all the old references towards Flavorizator to the new name (namespaces, classnames, texts etc).
- Heroes5MapEnhancer/MapEnhancer.cs: 'master' class that will launch the whole map enhancement process.
- added an icon to the exe file (better than the default one).
- deleted namespace Heroes5MapEnhancer.Configuration.
- added namespace Heroes5MapEnhancerDAL.Configuration.
- moved Configuration.cs & Configuration.xml files to the new Heroes5MapEnhancerDAL.Configuration namespace (& project).
- Configuration/Configuration.xml: added new <DeleteUnPAKedMaps /> setting.
- Configuration/Configuration.cs: added support for the new <DeleteUnPAKedMaps /> setting.
- PAK/MapUnPAKer.cs (UnPAK()): fixed a bug involving a bad value assignment to the root path of the unpaked map.
- PAK/MapPAKer.cs (PAK()): now PAKs map files into %appRoot%\publish\ & creates the publish directory if it doesn't exist.
- PAK/MapPAKer.cs (PAK()): added support for unPAKed files & directory cleanup if configured as such.

Build 5:
========

- Heroes5Flavorizator/Program.cs: main method, removed option 0 from the list.
- Heroes5Flavorizator/Program.cs: main method, added option 2 to the list (quit).
- Heroes5Flavorizator/Program.cs: main method, changed the wording of option 1 (whole map instead of only artifacts).
- Heroes5Flavorizator/Program.cs: main method, finished rewriting the console loop.
- Heroes5Flavorizator/Program.cs: main method, externalized the 'done' var to the class level, for the new Quit command.
- Heroes5Flavorizator/Program.cs: new method, ParseInputString(string input) that analyzes what has been typed into the console.

Build 4:
========

- added namespace Heroes5Flavorizator.Configuration.
- Heroes5Flavorizator/Configuration.xml: this is the file that will be used to store configuration settings.
- Heroes5Flavorizator/Configuration.cs: this is the serializable/deserializable object mapping configuration settings with the xml file.
- Heroes5Flavorizator/Program.cs: main method, misc change - added the total of artifacts configured to the console output.
- Heroes5Flavorizator/Program.cs: main method, misc change - added the configured map path to the console output.
- Heroes5Flavorizator/Program.cs: main method, rewrite of the options input loop.
- Heroes5Flavorizator/Program.cs: main method, added a prettier title to the console app.
- Heroes5Flavorizator/Program.cs: removed the PrintMenu() method.

Build 3:
========

- LINQLayer/ArtifactHelper.cs: renamed to ArtifactReader.cs (+ classname).
- FlavorizatorDAL/FArtifact.cs: renamed to DArtifact.cs (+ classname) meaning Database artifact, more consistant.
- FlavorizatorDAL/Database.cs: added thread-safe singleton implementation.
- Heroes5Flavorizator/Project properties: set the project output to Console app. UI implementation put on the backburner for now.
- Heroes5Flavorizator/Project.cs: added args support to the Main method. If no args are present, the console mode will be executed.
- added namespace MapAPI.PAK.
- PAK/MapUnPAKer.cs: class handling the unpaking of map files (pak/zip format).
- PAK/MapPAKer.cs: class handling the paking of map files (pak/zip format).
- added ICSharpCode.SharpZipLib to the MapAPI project.

Build 2:
========

- FlavorizatorDAL/Database.xml: this is the main file containing all the flavor texts for the application.
- FlavorizatorDAL/FArtifact.cs: basic serializable data structure that will be contained inside Database.xml
- FlavorizatorDAL/Database.cs: the main representation of the Database.xml file in a serializable object-oriented way.
- Heroes5Flavorizator/MainForm.cs: basic UI design / data loading from Database.xml.
- Heroes5Flavorizator/AddArtifactTextForm: UI for adding a text to a selected artifact.

Build 1:
========

- added namespace MapAPI.MapMiscDataStructures.
- added MapMiscDataStructures/PointLightsItem.cs: data structure for <pointLights> elements.
- added MapMiscDataStructures/Color.cs: data structure for <Color> elements.
- moved Pos.cs to MapAPI.MapMiscDataStructures.
- MapMiscDataStructures/Pos.cs: added parameter-less constructor.
- moved ArmySlotsItem.cs to MapAPI.MapMiscDataStructures.
- MapObjects/Artifact.cs: added private & public members for <pointLights> elements.
- MapObjects/Artifact.cs: renamed _combatScript field to _combatScriptHref.
- MapObjects/Artifact.cs: renamed CombatScript property to CombatScriptHref.
- LINQLayer/ArtifactHelper.cs (GetArtifacts()): combat script href attribute value is now correctly fetched.
- LINQLayer/ArtifactHelper.cs (GetArtifacts()): added support for <pointLights> elements.
- LINQLayer/ArtifactHelper.cs (GetArtifacts()): rewritten & refactored (calls to private methods in charge of building complex types).
- LINQLayer/ArtifactHelper.cs: added BuildPosFromXElements(IEnumerable<XElement> linqPosElements) method.
- LINQLayer/ArtifactHelper.cs: added Color BuildColorFromXElements(IEnumerable<XElement> linqColorElements) method.
- LINQLayer/ArtifactHelper.cs: added List<ArmySlotsItem> BuildArmySlotsFromXElements(IEnumerable<XElement> linqArmySlotsElements) method.
- LINQLayer/ArtifactHelper.cs: added List<PointLightsItem> BuildPointLightsFromXEelements(IEnumerable<XElement> linqPointLightsElements) method.
- LINQLayer/ArtifactHelper.cs: added Artifact BuildArtifactFromXElement(Artifact artifact, XElement linqItem) method.
- added new project FlavorizatorDAL.


Build 0:
========

- Basic solution / projects layout & structure (subject to change heavily)
- Base set of classes:
- LINQLayer/ArtifactHelper.cs: main class in charge of querying map.xdb and return internal API objects for manipulation
- MapObjects/ArmySlotsItem.cs: class representing the set of data present in armySlots tags (artifacts, resources...)
- MapObjects/Artifact.cs: class used to manipulate artifact objects via the API.
- MapObjects/Item.cs: base superclass for map objects (artifacts etc).
- MapObjects/Map.cs: unused for now, but will eventually define the whole map.xdb in a clean object-oriented way.
- MapObjects/Pos.cs: class representing 3D coordinates (x,y,z) for map objects.
- LINQLayer/ArtifactHelper.cs: added base method skeleton for GetArtifactById(string id).
- LINQLayer/ArtifactHelper.cs: added first implementation of the GetArtifacts() method.
