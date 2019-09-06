using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPMVCListDemo.Controllers
{
    public class ListDemoController : Controller
    {
        // GET: ListDemo
        public ActionResult Index()
        {
            //lets use a view model here.
            TempListViewModel tempListViewModel = new TempListViewModel();

            //lets fill this view model instance with some values.
            tempListViewModel = FillUpViewModelWithValues();

            return View(tempListViewModel);
        }

        [HttpPost]
        public ActionResult Index(TempListViewModel tempListViewModel)
        {
            var selectedname = "";

            selectedname = tempListViewModel.selectedName;

            //I am sure there are better ways to check but put a break point at this line
            //for Redirection Action and you will see that selectedname
            //holds the value that was selected in the view.

            return RedirectToAction("Index");
        }

        private TempListViewModel FillUpViewModelWithValues()
        {
            TempListViewModel tempListViewModel = new TempListViewModel();

            tempListViewModel.somevalue1 = 10;
            tempListViewModel.somevalue2 = 20;

            tempListViewModel.listOfNames = FillUpListOfNames();

            //note - we are intentionally leaving the selectedName field of the view model empty


            return tempListViewModel;
        }

        private List<string> FillUpListOfNames()
        {
            List<string> listOfNames = new List<string>();

            //add some names
            listOfNames.Add("Bruce Wayne");
            listOfNames.Add("Kit Walker");
            listOfNames.Add("Ghost Who Walks");
            listOfNames.Add("The Dark Knight");
            listOfNames.Add("Devil");
            listOfNames.Add("Gray Ghost");

            return listOfNames;
        }
    }

    //some view models.
    public class TempListViewModel
    {
        //this is a list of names.
        //this can be a list of anything. even complex objects.
        //later we will be doing a select list out of this list.
        //note that this demo assumes that any value that goes on the view will be in string format
        //we send it in string format (no matter what format it is) and 
        public List<string> listOfNames { set; get; }

        //the selected name from the above list will be stored here
        //this is essential because the current view model will be sent from the controller
        //and recieved back in the controller.
        //if we dont store this here, we wont get it back.
        public string selectedName { set; get; }

        public int somevalue1 { set; get; }

        public int somevalue2 { set; get; }
    }
}