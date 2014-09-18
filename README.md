Advanced String Visualizer
==========================

An advanced string debugger visualizer for Visual Studio .NET 2008.

> *Visualizers are components of the Visual Studio debugger user interface. A visualizer creates a dialog box or another interface to display a variable or object in a manner that is appropriate to its data type. -[MSDN](http://msdn.microsoft.com/en-us/library/zayyhzts.aspx)*

![screenshot1](http://files.glassocean.net/github/adv-string-vis1.jpg)

![screenshot2](http://files.glassocean.net/github/adv-string-vis2.jpg)

Usage
-----
1. Download the Release package and extract the AdvancedStringVisualizer.dll file into your Visual Studio 2008 Visualizers folder (usually located under "My Documents\Visual Studio 2008\Visualizers").
2. Restart Visual Studio, then start debugging a project. Use a breakpoint or instruct the debugger to stop at a string, then hover your mouse cursor over the string and click the magnifying glass to view the string in the Advanced String Visualizer.

History
-------
While developing libraries and apps that deal with byte streams and byte arrays on a low level, I needed a way to visualize strings that contain null characters (byte 0). When viewing a string in any of the default visualizers (HTML, XML or Text), the string will terminate upon the first appearance of a null character, but this does not accurately represent the string because there could be more characters after the null, you just can't see them in the visualizer. For this reason I built the Advanced String Visualizer, which has the ability the replace nulls with an underscore character instead, or view the string in a different format/encoding. It's based on a project I found [here](http://vsstringdebugvisualizer.codeplex.com/), but that one is coded in C# and only works for Visual Studio 2012, whereas the version I've developed is coded in VB.NET for Visual Studio 2008. I give credit to it's original author, David Michener.
