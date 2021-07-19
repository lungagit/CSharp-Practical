using CSharp.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSharp.Test
{
    //[TestClass]
    //public class InvoiceTest
    //{

    //    [TestMethod]
    //    public void MonthOneInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(1, invoiceItemList, month);
    //        var expected = new Invoice(1, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(1)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(1, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthTwoInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(2, invoiceItemList, month);
    //        var expected = new Invoice(2, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(1).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(2)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(2, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthThreeInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(3, invoiceItemList, month);
    //        var expected = new Invoice(3, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(2).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(3)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(3, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthFourInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(4, invoiceItemList, month);
    //        var expected = new Invoice(4, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(3).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(4)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(4, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthFiveInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(5, invoiceItemList, month);
    //        var expected = new Invoice(5, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(4).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(5)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(5, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthSixInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var invoiceRepository = new InvoiceRepository();
    //        var inv = new Invoice(6, invoiceItemList, month);
    //        var expected = new Invoice(6, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(5).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(6)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(6, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthSevenInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(7, invoiceItemList, month);
    //        var expected = new Invoice(7, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(6).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(7)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(7, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthEightInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(8, invoiceItemList, month);
    //        var expected = new Invoice(8, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(7).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(8)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(8, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthNineInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(9, invoiceItemList, month);
    //        var expected = new Invoice(9, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(8).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(9)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(9, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthTenInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(10, invoiceItemList, month);
    //        var expected = new Invoice(10, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(9).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(10)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(10, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthElevenInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var inv = new Invoice(11, invoiceItemList, month);
    //        var expected = new Invoice(11, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(10).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(11)

    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(11, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthTwelveInvoiceDates()
    //    {
    //        //Arrang
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var invoiceRepository = new InvoiceRepository();
    //        var inv = new Invoice(12, invoiceItemList, month);
    //        var expected = new Invoice(12, invoiceItemList, month)
    //        {
    //            InvoiceDate = inv.CalculateInvoiceDate(month).AddMonths(11).AddDays(-5),
    //            InvoiceDueDate = inv.CalculateInvoiceDueDate(month).AddMonths(12)
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(12, month);

    //        //Assert
    //        Assert.AreEqual(expected.InvoiceDate, actual.InvoiceDate);
    //        Assert.AreEqual(expected.InvoiceDueDate, actual.InvoiceDueDate);

    //    }

    //    [TestMethod]
    //    public void MonthOneInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(1, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>() 
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 60m,
    //                    RatePerHour = 150m,
    //                    Description = "Analysis and Planning, defining use cases and capturing detailed functional requirements.",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 8m,
    //                    RatePerHour = 80m,
    //                    Description = "Sketch Your App Idea, Sketch out your app idea with pen and paper.",
    //                }
    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(1, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }
                
    //    }

    //    [TestMethod]
    //    public void MonthTwoInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(2, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 40m,
    //                    RatePerHour = 100m,
    //                    Description = "UI / UX Design. Creating Mockups of the app."
    //                },

    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(2, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthThreeInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(3, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 24m,
    //                    RatePerHour = 250m,
    //                    Description = "Build Your App Landing Page",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 120m,
    //                    RatePerHour = 200m,
    //                    Description = "Prototype",
    //                }
    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(3, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthFourInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(4, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 240m,
    //                    RatePerHour = 350m,
    //                    Description = "Back-End/Server Technology",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 60m,
    //                    RatePerHour = 180m,
    //                    Description = "API development",
    //                }
    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(4, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthFiveInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(5, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 160m,
    //                    RatePerHour = 250m,
    //                    Description = "Mobile App Front-End development",
    //                },

    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(5, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthSixInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(6, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 45m,
    //                    RatePerHour = 120m,
    //                    Description = "User Experience Testing.",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 60m,
    //                    RatePerHour = 100m,
    //                    Description = "Functional Testing",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 50m,
    //                    RatePerHour = 170m,
    //                    Description = "Performance Testing",
    //                }
    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(6, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthSevenInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(7, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 80m,
    //                    RatePerHour = 150m,
    //                    Description = "Security Testing."
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 100m,
    //                    RatePerHour = 200m,
    //                    Description = "Device and Platform Testing",
    //                },

    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(7, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthNineInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(9, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 70m,
    //                    RatePerHour = 200m,
    //                    Description = "Bug fixing.",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 4m,
    //                    RatePerHour = 60m,
    //                    Description = "Testing fixed bugs.",
    //                },

    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(9, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthEightInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(8, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 16m,
    //                    RatePerHour = 150m,
    //                    Description = "Deployment & Support",
    //                },
    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(8, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthTenInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(10, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 60m,
    //                    RatePerHour = 150m,
    //                    Description = "Adding the infinit scroll and refresh feature",
    //                },
    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(10, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthElevenInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(11, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 5m,
    //                    RatePerHour = 120m,
    //                    Description = "Attending to technical issues.",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 40m,
    //                    RatePerHour = 60m,
    //                    Description = "Market the app to reach the right people.",
    //                },

    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(11, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void MonthTwelveInvoiceItems()
    //    {
    //        //Arrange
    //        var month = DateTimeOffset.UtcNow.Month;
    //        var invoiceRepository = new InvoiceRepository();
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var expected = new Invoice(9, invoiceItemList, month)
    //        {
    //            InvoiceItems = new List<InvoiceItem>()
    //            {
    //                new InvoiceItem(1)
    //                {
    //                    HoursWorked = 240m,
    //                    RatePerHour = 150m,
    //                    Description = "App maintenance.",
    //                },

    //                new InvoiceItem(2)
    //                {
    //                    HoursWorked = 80m,
    //                    RatePerHour = 85m,
    //                    Description = "Improving the app with user feedback.",
    //                },

    //            }
    //        };

    //        //Act
    //        var actual = invoiceRepository.Retrieve(12, month);

    //        //Assert
    //        for (int i = 0; i < 1; i++)
    //        {
    //            Assert.AreEqual(expected.InvoiceItems[i].HoursWorked, actual.InvoiceItems[i].HoursWorked);
    //            Assert.AreEqual(expected.InvoiceItems[i].RatePerHour, actual.InvoiceItems[i].RatePerHour);
    //            Assert.AreEqual(expected.InvoiceItems[i].Description, actual.InvoiceItems[i].Description);
    //        }

    //    }

    //    [TestMethod]
    //    public void ValidateValidInvoice()
    //    {
    //        //Arrang
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var invoice = new Invoice(1, invoiceItemList, 1)
    //        {
    //            InvoiceReferenceNumber = "INV001",

    //        };

    //        bool expected = true;

    //        //Act
    //        bool actual = invoice.Validate();

    //        //Assert
    //        Assert.AreEqual(expected, actual);

    //    }

    //    [TestMethod]
    //    public void ValidateMissingInvoiceNumber()
    //    {
    //        //Arrang
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var invoice = new Invoice(1, invoiceItemList, 1)
    //        {

    //        };

    //        bool expected = false;

    //        //Act
    //        bool actual = invoice.Validate();

    //        //Assert
    //        Assert.AreEqual(expected, actual);

    //    }

    //    [TestMethod]
    //    public void ValidateEmptyInvoiceNumber()
    //    {
    //        //Arrang
    //        var invoiceItemList = new List<InvoiceItem>();
    //        var invoice = new Invoice(1, invoiceItemList, 1)
    //        {
    //            InvoiceReferenceNumber = "",
    //        };

    //        bool expected = false;

    //        //Act
    //        bool actual = invoice.Validate();

    //        //Assert
    //        Assert.AreEqual(expected, actual);

    //    }

    //    [TestMethod]
    //    public void ValidateValidInvoiceItem()
    //    {
    //        //Arrange
    //        var invoiceItem = new InvoiceItem(1)
    //        {
    //            HoursWorked = 45m,
    //            RatePerHour = 120m
    //        };

    //        bool expected = true;

    //        //Act
    //        bool actual = invoiceItem.Validate();

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void ValidatenNegativeHoursWorked()
    //    {
    //        //Arrange
    //        var invoiceItem = new InvoiceItem(1)
    //        {
    //            HoursWorked = -45m,
    //        };

    //        bool expected = false;

    //        //Act
    //        bool actual = invoiceItem.Validate();

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }

    //    [TestMethod]
    //    public void ValidateZeroRatePerHour()
    //    {
    //        //Arrange
    //        var invoiceItem = new InvoiceItem(1)
    //        {
    //            RatePerHour = 0m
    //        };

    //        bool expected = false;

    //        //Act
    //        bool actual = invoiceItem.Validate();

    //        //Assert
    //        Assert.AreEqual(expected, actual);
    //    }
    //}
}
