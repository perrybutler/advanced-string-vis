Advanced String Visualizer
==========================

An advanced string debugger visualizer for Visual Studio .NET 2008.

> *Visualizers are components of the Visual Studio debugger user interface. A visualizer creates a dialog box or another interface to display a variable or object in a manner that is appropriate to its data type. -[MSDN](http://msdn.microsoft.com/en-us/library/zayyhzts.aspx)*

In the following screenshot, on the left side the string appears to be very short, but the length and hex representation on the right side seem to indicate otherwise:

![screenshot1](http://files.glassocean.net/github/adv-string-vis1.jpg)

Why is that? Well, let's look a bit closer at what the hex values tell us. On the left side, we see a string consisting of 7 letters/numbers. On the right is the hex representation of this string - each pair of numbers is the hex code for a single character in the string. The first hex code, 47, represents the capital letter G. So what do we have at the eighth hex pair? **A null character.** When null characters appear in a form control such as a textbox, they cause the string to terminate immediately at that null even if there are more characters in the string.

The following screenshot is the same screenshot as above, with Purge Nulls turned on for the ASCII. Obviously, the string is much longer than what it first appeared to be:

![screenshot2](http://files.glassocean.net/github/adv-string-vis2.jpg)

Usage
-----
1. Download the Release package and extract the AdvancedStringVisualizer.dll file into your Visual Studio 2008 Visualizers folder (usually located under "My Documents\Visual Studio 2008\Visualizers").
2. Restart Visual Studio, then start debugging a project. Use a breakpoint or instruct the debugger to stop at a string, then hover your mouse cursor over the string and click the magnifying glass to view the string in the Advanced String Visualizer.

FAQ
---
*Can I use this in other versions of Visual Studio?* Apparently you can:

> *"To use this visualizer with other versions of Visual Studio, just change the Microsoft.VisualStudio.DebuggerVisualizers references to the version that aligns with your Visual Studio version." -David Michener*

History
-------
While developing libraries and apps that deal with byte streams and byte arrays on a low level, I needed a way to visualize strings that contain null characters (byte 0). When viewing a string in any of the default visualizers (HTML, XML or Text), the string will terminate upon the first appearance of a null character, but this does not accurately represent the string because there could be more characters after the null, you just can't see them in the visualizer. For this reason I built the Advanced String Visualizer, which has the ability the replace nulls with an underscore character instead, or view the string in a different format/encoding. It's based on a project I found [here](http://vsstringdebugvisualizer.codeplex.com/), but that one is coded in C# for Visual Studio 2012, whereas the version I've developed is coded in VB.NET for Visual Studio 2008. I give credit to it's original author, David Michener.
