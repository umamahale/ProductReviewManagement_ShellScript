using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Linq;

namespace ProductReviewManagementWithLinq
{
    class Management
    {
        public DataTable dataTable = new DataTable();
        public void TopRecords(List<ProductReviewManagement> listProductReview)
        {
            var recordsData = (from productreviews in listProductReview
                               orderby productreviews.Rating descending
                               select productreviews).Take(3);

            foreach (var list in recordsData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.islike);
            }
        }

        public void SelectedRecords(List<ProductReviewManagement> listProductReview)
        {
            var recordData = from productReviews in listProductReview
                             where (productReviews.ProductID == 1 || productReviews.ProductID == 4 || productReviews.ProductID == 9) &&
                             productReviews.Rating > 3
                             select productReviews;

            foreach (var list in recordData)
            {
                Console.WriteLine("ProductID:-" + list.ProductID + " " + "UserID:-" + list.UserID + " " + "Rating:-" + list.Rating + " " + "Review:-" + list.Review + " " + "isLike:-" + list.islike);
            }
        }

        public void RetrieveCountOfRecords(List<ProductReviewManagement> listProductReview)
        {
            var RecordData = listProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });


            foreach (var list in RecordData)
            {
                Console.WriteLine(list.ProductID + "------- " + list.Count);
            }
        }
    }
}


