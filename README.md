# ClojureClr-Dll-bug
Repo demonstrating bugs: 
- using ClojureClr nuget package. (ClojureClr v1.8.0)  =ILLMerege missing clojure.core.server.dll=
- loading ClojureClr from refered a dll. =ClojureClr is expects to be loaded from the root of calling application. Copying clojure files to the root of calling application fixes the exeptions. Still very inconveniant when developing plugins that are loaded by an application you have no conrol over.=





