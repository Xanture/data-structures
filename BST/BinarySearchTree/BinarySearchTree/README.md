2ez
Have a picture: https://imgur.com/a/5JtYw

Traversal update 10/16 9:45:

I've been pondering about a problem i've had since I left school day about my traveral method not working correctly.
In it's curent state it would traverse all the way down the left side like I wanted but I found out the way i was trying
to keep track of which node I was on wasn't going back up the tree and was stuck on the bottom. So after some dinner and a
long shower it came to me. I could feed the traveral method the root and continue to use recursion but it should keep track
of the node on the way back up. First attempt didn't work. Debug time.