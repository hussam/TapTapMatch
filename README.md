# TapTapMatch
Simple two-player game for Apple Watch + iPhone

###What is it?

A simple two-person tapping game. One player uses the
iPhone, the other uses an Apple Watch. Whoever taps more in 30 seconds, wins.

###But why??

I started on this because of I wanted to try out WatchKit development (this is
my first WatchKit app), and was
[was encouraged by this contest
announcement](http://blog.xamarin.com/xamarin-contest-design-for-apple-watch/)).
Most Apple Watch applications I've seen were either for consuming notifications,
or inputing data. This makes sense given the watch's form-factor. However, I
wanted to see what more we can do. I originally wanted to do something with the
Haptic engine or Taptic feedback, but these APIs aren't open yet unfortunately.
So I chose this project.

###Cool highlights

   * When the watch application launches, it pauses until the phone application
    is launched. It automatically detects when that happens and proceeds.

   * The watch app (the extension project) is the "driver" for the
   experience. It launches the game on both the watch and the full phone
   app.

   * The phone and watch applications are constantly exchanging data
   about user taps.

[Video](https://www.youtube.com/watch?v=NbSd11Nc0PI)
