# BindingFlagsTester
WinForms app to allow for trial-and-error checking of [`BindingFlags`](https://msdn.microsoft.com/en-us/library/system.reflection.bindingflags.aspx) 
used in reflection.

![Screenshot](http://cliss.github.io/screenshot.png)

There are two classes in the project, `Base` and `Dervied`, that simply 
exercise the various combinations of `BindingFlags` that can be used.

To use, run the app, select whether you wish to work with the Base or
Derived class, and whether you wish to read Fields, Properties, or
Methods.

Select your binding flags, and then hit Go.
