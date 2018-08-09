using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShopperWebApp.Models;

namespace ShopperWebApp.Controllers
{
    public class ListingController : Controller
    {
        // GET: Listing
        public ActionResult Index(string category)
        {
            var electronicsCategory = new CategoryModel
            {
                Id = 1,
                Name = "Electronics",
                Description = "Consoles, Tvs, Microwaves, Phones, etc."
            };

            var foodCategory = new CategoryModel
            {
                Id = 1,
                Name = "Foods",
                Description = "Peanuts, poutines, pazzas, etc."
            };

            ViewBag.Categories = new List<string> {"Electronics", "Foods"};

            var xboxPictures = new List<PictureModel>
            {
                new PictureModel
                {
                    Id = 1,
                    Description = "Xbox",
                    Url = "http://hight-tech-reviews.e-monsite.com/medias/images/wide-a467935d.jpg",
                    IsHeader = true,
                    Order = 1
                },

                new PictureModel
                {
                    Id = 2,
                    Description = "Another Xbox",
                    Url = "http://hight-tech-reviews.e-monsite.com/medias/images/xboxone-1600-2.jpg",
                    IsHeader = false,
                    Order = 2
                }
            };


            var items = new List<ItemModel>
            {
                new ItemModel
                {
                    Id = 1,
                    Name = "Xbox One 1",
                    Description = "This is a slightly used Xbox One in very good condition.",
                    Price = 199,
                    Category = electronicsCategory,
                    Pictures = xboxPictures
                },

                new ItemModel
                {
                    Id = 2,
                    Name = "Xbox One 2",
                    Description = "This is a slightly used Xbox One in very good condition.",
                    Price = 299,
                    Category = electronicsCategory,
                    Pictures = xboxPictures
                },

                new ItemModel
                {
                    Id = 3,
                    Name = "Xbox One 3",
                    Description = "This is a slightly used Xbox One in very good condition.",
                    Price = 399,
                    Category = electronicsCategory,
                    Pictures = xboxPictures
                },

                new ItemModel
                {
                    Id = 4,
                    Name = "Xbox One 4",
                    Description = "This is a slightly used Xbox One in very good condition.",
                    Price = 499,
                    Category = electronicsCategory,
                    Pictures = xboxPictures
                },

                new ItemModel
                {
                    Id = 5,
                    Name = "Xbox One 5",
                    Description = "This is a slightly used Xbox One in very good condition.",
                    Price = 599,
                    Category = electronicsCategory,
                    Pictures = xboxPictures
                },

                new ItemModel
                {
                    Id = 6,
                    Name = "Xbox One 6",
                    Description = "This is a slightly used Xbox One in very good condition.",
                    Price = 699,
                    Category = electronicsCategory,
                    Pictures = xboxPictures
                }
            };

            return View(items);
        }

        // GET: Listing/Details/5
        public ActionResult Details(int id)
        {
            var electronicsCategory = new CategoryModel
            {
                Id = 1,
                Name = "Electronics",
                Description = "Consoles, Tvs, Microwaves, Phones, etc."
            };

            var xboxPictures = new List<PictureModel>
            {
                new PictureModel
                {
                    Id = 1,
                    Description = "Xbox",
                    Url = "http://hight-tech-reviews.e-monsite.com/medias/images/wide-a467935d.jpg",
                    IsHeader = true,
                    Order = 1
                },

                new PictureModel
                {
                    Id = 2,
                    Description = "Another Xbox",
                    Url = "http://hight-tech-reviews.e-monsite.com/medias/images/xboxone-1600-2.jpg",
                    IsHeader = false,
                    Order = 2
                }
            };

            var item = new ItemModel
            {
                Id = 5,
                Name = "Xbox One 5",
                Description = "This is a slightly used Xbox One in very good condition.",
                Price = 599,
                Category = electronicsCategory,
                Pictures = xboxPictures
            };

            return View(item);
        }

        // GET: Listing/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Listing/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemModel item)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Listing/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Listing/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Listing/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Listing/Delete/5
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