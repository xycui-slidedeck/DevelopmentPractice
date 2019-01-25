# Methodology & Practice in (.NET) Development

---

# Content
## Part 1: Before coding    
## Part 2: Working on project     
## Part 3: Other thinking
## Summary

.notes: Part 1. Ignored in large project. Because they already finished these parts.
Part 2. Dealing with actual project.
Part 3. Some other thinkings

---

# Part 1: Before coding

---
# *Code* Repository
### What is the structure? 
<br/>

|Category|Samples|Usage|
|----|------|-----|
|Source Code|/src|contain the source codes or tests|
|Documents|/docs<br/>\*.rst; \*.md|docs folder or markdown/reStructuredText for documents|
|Other functional files|git config files<br/>CI\* config files(appveyor,travis,circle)<br/>package dependency(package.json,requirement.txt)<br/>...|For extended requirements & advanced features|
|Scripts|init<br/>build<br/>|including some script for us to execute for environment preparing. Save time from duplicate typing|     

- All of them required?
- Why not put source code out side?

```notes
1. Not all required. Former more important.
2. Control the growth of code

```

---

![Newtonjson](.\images\structure_newtonjson_note.png "Newtonjson") ![NetStandard](.\images\structure_netstandard.png "NetStandard")     
###### - NewtonJson: https://github.com/JamesNK/Newtonsoft.Json<br/>- Pyinstaller: https://github.com/pyinstaller/pyinstaller<br/>- NetCore(multiple Readme): https://github.com/dotnet/core

```notes
Net core *
```
---
# Projects
### What is in project?   

|Items|Note|
|----|----|
|**Source code**|-|
|**Config/resource file**|Avoid put dependency like .dll/.jar except native|
|**Dependency/Description file**|.csproj/.vcxproj *package.config* in .NET, pom.xml/build.gradle in Java, |   
<br/>   

### Types of projects?
![Project type](.\images\project_type.png "Project type")![TtsSelfHost](.\images\tts-selfhost_structure.png "Tts SelfHost")![Mediaplatform](.\images\mediaplatform_structure.png "Mediaplatform")

```notes

```
---
# Practice on Project
### How to construct?
1. For large (extended) project. Create *Interface* Project. And also the 'Implement Project'(eg. [MongoDB CSharp Driver](https://github.com/mongodb/mongo-csharp-driver "MongoDB CSharp Driver"), [XiaoIce](https://msasg.visualstudio.com/Bing_STC-Asia/_git/XiaoIce?path=%2Fprivate%2Fsrc&version=GBmaster "XiaoIce")).
2. For task specific project. Just create library project.([NewtonJson](https://github.com/JamesNK/Newtonsoft.Json "NewtonJson"))
3. Create Test project(NUnit, XUnit for .NET) for test. Keep your playground code. If you write in Console you might need to delete them.

### Pakcage Reference?

|Reference type|Pros|Cons|
|----|---|---|
|Project reference|Latest dependency change could be applyed<br/>Easy debug|Build dependency each time<br/>Extra large repo<br/>Even with git submodule<br/>Build break risk|
|NuGet reference|Fast on build|Debug require aditional nupkg or pdb<br/>Cost on package publish|

---

# .NET Project
### Net Core & Net Framework
- Previous using Net framework(Heavy(dependency), Platform fixed(mono is a kind of trade off by third party))
- .Net Core is platform. Open source. Nuget managed packages.
- .Net Core also provide a new standard of project management(new csproj). And use PackageReference replace package.config. (Compatible with old one)
- For Application(Runtime)
- Not compatible between each other
### Net Standard
- **Library** standard(constraint). Not for runtime.
- Could be referenced by Standard/Core/Framework with [condition](https://docs.microsoft.com/en-us/dotnet/standard/net-standard "Net standard")

---

# Takeaway
#### 1. Create/Reuse library/project depends on requirement. 
#### 2. Concept of interface! Concept of interface! Concept of interface!   
##### - Large scale system: Interface project for behaviour reusing.   
##### - Standalone feature: Interface & implement in same library/project.   
#### 3. App is just a wrapper for interactive. 
#### 4. Web is also a kind of Console -- Do more Self-host(Owin, Kestrel, Flask) 
#### 5. Project as a service.
#### 6. Jump out of the sln concept for .NET development

```notes
1. Util is a class should not become a project. Avoid fragment of projects.
2. Focus on folder. solution is just for visualize the relationship. (Build setting)

```
---

# Clean Environment
1. Build environment - DockerFile
2. Package dependency - NuGet.Configs
3. Resource file dependency - Relative path/Embedded resource/resx file

---

# Part 2: Working on project

---

# Part 3: Other thinking

---

# IDE vs CLI    
<br/>   

|Tools|Pros|Cons|
|------|---|---|
|**IDE**|1. Easy to use<br/>2. Clear with UI <br/>3. Plugins |1. Ignore a lot of details<br/>2. Unstable|
|**CLI**|1. Make users understand the details<br/>2. Developer friendly |1. Not intuitive <br/>2. Cost time to learn|

###### \*IDE: *I*ntegrated *D*evelopment *E*nvironment<br/>\*CLI: *C*ommand *L*ine *I*nterface

```notes
IDE: UI with mouse to provide a lot of easy access. Detail is ignored so the folder project structure is ignored.
CLI: Key board access could be much more easier than click the mouse/switch between
```

---
# Console vs Platform/Framework specific(web, worker)
### Console:
- Flexible in development & deployment
- More and more library/framework support SelfHost/ConsoleHost (Owin, Kestrel)
- Understand the detail better.

### Platform/Framework specific
- Provide a managed process on development. Avoid some mistake at beginning.
- Hard to migrate(1. Worker role/Web role 2. .NET Web application binded to IIS)


```notes
Framework specific:
learning cost ?
```
---

# Summary
- Focus more on folder structure not project/sln.
- Cleaning environment & reusable module/library
- Use more 'vs' when searching (Mono vs Net Core).
- Try more command line tool.

---
# Reference
<br/>

|Concepts|Explain|Tools/Service|
|----|---|----|
|CI/CD| Continous Integration/Continous Delivery|Appveyor, VSTS(Cloud build), Travis,Circle|
|Scaffolding|Structure of a project for languages|Yeoman|
|Package management|Dependency managment|NuGet, npm, pip, scoop, chocolatey|

---

# Thanks