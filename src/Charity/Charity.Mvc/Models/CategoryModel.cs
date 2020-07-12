using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Charity.Mvc.Models
{
    public class CategoryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string GiftId { get; set; }
        //[ForeignKey("Id")]
        public DonationModel Gift { get; set; }
    }
}
/*
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (1, N'ubrania, które nadają się do ponownego użycia')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (2, N'ubrania, do wyrzucenia')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (3, N'zabawki')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (4, N'książki')
INSERT [dbo].[Categories] ([Id], [Name]) VALUES (5, N'inne')
     */
