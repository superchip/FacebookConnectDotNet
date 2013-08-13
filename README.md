FacebookConnectDotNet
=====================

Providing interface connecting to facebook and posting to feed


Steps in integrating with facebook

1.       Installed NuGet for visual studio and downloaded facebook package

2.       Create an app in facebook developer.

3.       Grant appropriate permissions.

4.       Acquired access token using javascript displaying the user the login and sending the information to facebook and receiving answer to handle that saves the access token to the session.

5.       Using Session["AccessToken"] to get user information/posting on behalf

 

How to use on your own?

1.       Open auth.html – line 11 – change appId to your app id.

2.       Open FBConnect.aspx – type your messege.

3.       Run auth.html

4.       Go to your facebook wall or event's wall and check
