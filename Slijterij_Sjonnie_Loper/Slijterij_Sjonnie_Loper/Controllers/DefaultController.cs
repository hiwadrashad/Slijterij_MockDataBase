using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Slijterij_Sjonnie_Loper.Models;
using Slijterij_Sjonnie_Loper.Services;

namespace Slijterij_Sjonnie_Loper.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult WhiskeyOverview(string searching)
        {
            if (SingletonData.WhiskeyInitialized == false)
            {
                SingletonData.StoreDataWhiskey = new MockDataStoreWhiskey();
                SingletonData.WhiskeyInitialized = true;
            }
            return View(SingletonData.StoreDataWhiskey.SearchWhiskeys(searching).ToList());
                // items.ToList()) ;
        }

        // GET: Default/Details/5
        public ActionResult DetailsWhiskey(string id)
        {
            if (SingletonData.WhiskeyInitialized == false)
            {
                SingletonData.StoreDataWhiskey = new MockDataStoreWhiskey();
                SingletonData.WhiskeyInitialized = true;
            }
            return View(SingletonData.StoreDataWhiskey.items.Where(x => x.Id == id).FirstOrDefault());
        }

        // GET: Default/Create
        public ActionResult CreateWhiskey()
        {
            return View();
        }

        // POST: Default/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateWhiskey(ModelWhiskey modelwhiskey)
        {
            try
            {
                // TODO: Add insert logic here
                if (SingletonData.WhiskeyInitialized == false)
                {
                    SingletonData.StoreDataWhiskey = new MockDataStoreWhiskey();
                    SingletonData.WhiskeyInitialized = true;
                }

                SingletonData.StoreDataWhiskey.items.Add(modelwhiskey);

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Edit/5
        public ActionResult Edit(int id)
        {
            if (SingletonData.WhiskeyInitialized == false)
            {
                SingletonData.StoreDataWhiskey = new MockDataStoreWhiskey();
                SingletonData.WhiskeyInitialized = true;
            }
            return View();
        }

        // POST: Default/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, ModelWhiskey modelwhiskey)
        {
            try
            {

                if (SingletonData.WhiskeyInitialized == false)
                {
                    SingletonData.StoreDataWhiskey = new MockDataStoreWhiskey();
                    SingletonData.WhiskeyInitialized = true;
                }
                // TODO: Add update logic here
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Default/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Default/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}