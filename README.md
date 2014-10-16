I needed to bind dynamically to the properties of one of the properties on each item in a collection; not just to the 
proerties of the object in the collection as is the normal case.

Starting from the examples at 
http://www.thomaslevesque.com/2009/03/27/wpf-automatically-sort-a-gridview-when-a-column-header-is-clicked/ and 
http://stackoverflow.com/questions/11274731/dynamic-generate-column-mvvm/11278187#11278187 we end up with a working ListView
that dynamically binds columns to properties in both the direct item and the item.property properties. It also adapts the sorting 
setup from www.thomaslevesque.com to work with the dynamic bindings.

Proof of concept done, a little reflection to truly dynamically configure the columns didn't take long at all.