Disposomatic for CodeRush
======
Provides:
 
  * 2 CodeIssues 
    * Class should Implement IDisposable
    * Fields should be Disposed
  * 2 CodeProviders 
    * Implement IDisposable
    * Dispose Fields.

Usage 
======
**Scenario 1**
 
A class which *does not* implement IDisposable, but which has fields of types which do.

The '**Class should Implement IDisposable**' CodeIssue highlights the class and provides the '**Implement IDisposable**' CodeProvider as a fix.

The '**Implement IDisposable**' CodeProvider implements IDisposable interface and disposes of all disposable fields appropriately in the newly created Dispose method.

**Scenario 2**
 
A class which *does* implement IDisposable, but which has some Disposable fields which are *Not* disposed

The '**Fields Should be Disposed**' CodeIssue highlights undisposed disposable fields in any class which does implement IDisposable. 

The '**Dispose Fields**' CodeProvider adds code to the Dispose method of the class which Disposes any undisposed fields
