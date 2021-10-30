using System;
using System.Collections.Generic;

namespace ProductReviewManagementWithLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Product review management problem statement");
            List<ProductReviewManagement> ProductReviewlist = new List<ProductReviewManagement>()
            {
                new ProductReviewManagement() { ProductID = 1, Rating = 5, Review = "good", islike = true },
                new ProductReviewManagement() { ProductID = 3, Rating = 5, Review = "good", islike = true },
                new ProductReviewManagement() { ProductID = 4, Rating = 5, Review = "good", islike = false },
                new ProductReviewManagement() { ProductID = 7, Rating = 5, Review = "good", islike = true },
                new ProductReviewManagement() { ProductID = 8, Rating = 5, Review = "good", islike = false },
                new ProductReviewManagement() { ProductID = 9, Rating = 5, Review = "good", islike = true },
                new ProductReviewManagement() { ProductID = 13, Rating = 5, Review = "good", islike = true },

            };
            foreach(var list in ProductReviewlist)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.islike);
                //}

                Management management = new Management();
                //Uc-2
                //management.TopRecords(ProductReviewlist);

                //uc-3
                //management.SelectedRecords(ProductReviewlist);

                //uc-4
                management.RetrieveCountOfRecords(ProductReviewlist);
            }
        }
    }

        }
    

