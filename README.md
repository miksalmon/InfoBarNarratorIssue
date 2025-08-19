# InfoBarNarratorIssue

This is a min repro app to showcase an issue with the narrator announcement of an InfoBar when opened or closed in a Navigated event. 

Narrator announcement work correctly when opened or closed on its own. This can be tested using the Is Open checkbox in the min repro app. 

When navigating to page 2, the InfoBar is opened. There is no screen reader announcement. NarratorBuddy shows it is being announced, but it cannot be heard. It seems to be overtaken by the NavigationView's selected menu item announcement.

Navigating to page 1 closes the InfoBar. No announcement is made at all saying it is dismissed.