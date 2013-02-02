URLSchemeSupport
================

Provides a basic check for whether a given URL scheme is available on iOS. 

Why?
----

Maybe you have two apps, and want to be able to launch one from the other. Create custom URL schemes for each, and each app checks for the other. If the scheme is not installed, maybe you link to the App Store instead.


Documentation
=============


### URLSchemeSupport.isURLSchemeSupported (string urlScheme)

Returns true if the URL scheme is available.


