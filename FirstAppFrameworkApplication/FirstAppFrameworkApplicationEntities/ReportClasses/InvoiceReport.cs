using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppFramework.AppClasses;
using AppFramework.Controls;
using FirstAppFrameworkApplicationEntities.EDTs;
using FirstAppFrameworkApplicationEntities.EntityClasses;
using AppFramework.Linq;
using AppFramework.AppClasses.EDTs;

namespace FirstAppFrameworkApplicationEntities.ReportClasses
{
    class OrderReport : MicrosoftReportViewerReportRun
    {
        Dictionary<string, OrderReportDataLine> OrderList { get; set; }
        public string OrderID { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public Order OrderInstance { get; set; }

        public override MicrosoftReportViewerReportType ReportType
        {
            get { return MicrosoftReportViewerReportType.File; }
        }
        public override bool prompt()
        {
            //IValueDataControl orderId = this.addParameter(new OrderEDT());
            IValueDataControl fromDate = this.addParameter(new DateEDT(), "From");
            IValueDataControl toDate = this.addParameter(new DateEDT(), "To");
            var result = base.prompt();
            
            //OrderID = orderId.StringValue;
            FromDate = fromDate.DateTimeValue;
            ToDate = toDate.DateTimeValue;

            if (FromDate < DateTime.MinValue || ToDate < DateTime.MinValue)
            {
                throw new Exception("invalid date(s)");
            }
            else if (FromDate > ToDate)
            {
                throw new Exception("invalid date(s)");
            }


            return result;
        }

        public override void initDataSources()
        {

            if (Args.EntityBaseList != null )
            {
                OrderList = new Dictionary<string, OrderReportDataLine>();
                foreach (var x in Args.EntityBaseList)
                {
                    var item = getReportDataByOrder((Order)x);
                    OrderList.Add(item.OrderID, item);
                }
                //setReportDataWithListOfID(xx);
            }
            //else if (Args.EntityBase != null)
            //{
            //    OrderInstance = (Order)Args.EntityBase;
            //    OrderID = OrderInstance.OrderID;
            //    setReportDataWithID();
            //}
            else
            {
                getReportDataByDate();
                //if (OrderID != null)
                //{
                //    if (FromDate.Year >= 2015 && ToDate.Year > 2015)
                //        setReportDataWithDateAndID();
                //    else
                //        setReportDataWithID();
                //}                        
            }

            LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Order", OrderList.Values.ToList()));
        }

        //private void setReportDataWithListOfID(List<Order> param)
        //{
        //    foreach (Order o in param)
        //    {
        //        var x = (from i in new QueryableEntity<Order>()
        //                 join u in new QueryableEntity<Users>() on i.CreatedBy equals u.Username
        //                 join c in new QueryableEntity<Customers>() on i.CustomerID equals c.CustomerID
        //                 where i.OrderID == o.OrderID
        //                 select new OrderReportDataLine
        //                 {
        //                     OrderID = i.OrderID,
        //                     Customer = c.Name,
        //                     StaffName = u.Name,
        //                     Date = i.CreatedDateTime,
        //                 }).ToList();
        //        OrderList.Add(x[0].OrderID, x[0]);
        //    }
        //}

        private OrderReportDataLine getReportDataByOrder(Order order)
        {
            var x = (from i in new QueryableEntity<Order>()
                    join u in new QueryableEntity<Users>() on i.CreatedBy equals u.Username
                    join c in new QueryableEntity<Customers>() on i.CustomerID equals c.CustomerID
                    where i.OrderID == order.OrderID
                    select new OrderReportDataLine
                    {
                        OrderID = i.OrderID,
                        Customer = c.Name,
                        StaffName = u.Name,
                        Date = i.CreatedDateTime,
                    }).ToList();
            return x[0];
                         //.ToList().ToDictionary(x => x.OrderID, x => x);
        }

        private void getReportDataByDate()
        {            
            OrderList = (from i in new QueryableEntity<Order>()
                         join u in new QueryableEntity<Users>() on i.CreatedBy equals u.Username
                         join c in new QueryableEntity<Customers>() on i.CustomerID equals c.CustomerID
                         where i.CreatedDateTime <= ToDate && i.CreatedDateTime >= FromDate
                         select new OrderReportDataLine
                         {
                             OrderID = i.OrderID,
                             Customer = c.Name,
                             StaffName = u.Name,
                             Date = i.CreatedDateTime,
                         }).ToList().ToDictionary(x => x.OrderID, x => x);
        }


        public override void postInitDatasources()
        {
            LocalReport.SubreportProcessing += LocalReport_SubreportProcessing;
            //throw new NotImplementedException();
        }

        void LocalReport_SubreportProcessing(object sender, Microsoft.Reporting.WinForms.SubreportProcessingEventArgs e)
        {
            string orderId = e.Parameters["OrderID"].Values[0];
            OrderReportDataLine order = OrderList[orderId];
                        
            //var x = (from o in new QueryableEntity<Order>()
            //         join od in new QueryableEntity<OrderDetails>() on o.OrderID equals od.OrderID
            //         join i in new QueryableEntity<Items>() on od.ItemID equals i.ItemID
            //         where o.OrderID == order.OrderID
            //         select new OrderDetailsReportDataLine
            //         {
            //             Description = i.ItemName,
            //             Quantity = od.Quantity,
            //             UnitPrice = i.Price,
            //             Amount = od.Amount
            //         }).ToList();

            //var y = (from o in new QueryableEntity<OrderMiscCharges>()
            //         join m in new QueryableEntity<MiscCharge>() on o.MiscChargeID equals m.DeductionID
            //         where o.OrderID == order.OrderID
            //         select new ExtraCharges
            //         {
            //             Description = m.Description,
            //             Amount = o.Amount
            //         }).ToList();

            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Order", new List<OrderReportDataLine>() { order }));
            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Items", getOrderDetails(order)));
            e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ExtraCharges", getExtraCharges(order)));

            //e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Items", x));
            //e.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("ExtraCharges", y));

        }

        private  List<ExtraCharges> getExtraCharges(OrderReportDataLine order)
        {
            var y = (from o in new QueryableEntity<OrderMiscCharges>()
                    join m in new QueryableEntity<MiscCharge>() on o.MiscChargeID equals m.DeductionID
                    where o.OrderID == order.OrderID
                    select new ExtraCharges
                    {
                        Description = m.Description,
                        Amount = o.Amount
                    }).ToList();
            return y;
        }

        private List<OrderDetailsReportDataLine> getOrderDetails(OrderReportDataLine order)
        {
            var x = (from o in new QueryableEntity<Order>()
                                join od in new QueryableEntity<OrderDetails>() on o.OrderID equals od.OrderID
                                join i in new QueryableEntity<Items>() on od.ItemID equals i.ItemID
                                where o.OrderID == order.OrderID
                                select new OrderDetailsReportDataLine
                                {
                                    Description = i.ItemName,
                                    Quantity = od.Quantity,
                                    UnitPrice = i.Price,
                                    Amount = od.Amount
                                }).ToList();
            return x;
        }

        public override void postInitReport()
        {
            LocalReport.EnableExternalImages = true;
            //throw new NotImplementedException();
        }

        public override string reportPath()
        {
            return "Reports/InvoiceReportContainer.rdlc";
            //throw new NotImplementedException();
        }

        public override string Title
        {
            get { return "Invoice Report"; }
        }

        public class OrderReportDataLine
        {
            public string OrderID { get; set; }
            public string Customer { get; set; }
            public string StaffName { get; set; }
            public DateTime Date { get; set; }
        }

        public class OrderDetailsReportDataLine
        {
            public string Description { get; set; }
            public int Quantity { get; set; }
            public decimal UnitPrice { get; set; }
            public decimal Amount { get; set; }
        }
        
    }
    public class ExtraCharges
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }
    }
}
