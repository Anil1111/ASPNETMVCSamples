# ASP List Demo

One of the more common challenges my students keep running into, is, how to use a simple select list. and also send the list selection information back to the controller.

Look at ListDemoController

we send a list of names after packing it in a view model - TempListViewModel
and when the view model comes back to the controller, it will have the selected value

Check this public class ListDemoController : Controller

and head straight to the following two functions to see what I am talking about. 

the URI path might look something like this 

http://localhost:52772/ListDemo

public ActionResult Index()

and

public ActionResult Index(TempListViewModel tempListViewModel)

follow the break point instructions to see what I am talking about here. 

This demo looks into that. 
