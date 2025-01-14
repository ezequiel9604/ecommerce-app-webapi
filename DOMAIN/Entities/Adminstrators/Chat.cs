﻿
using Domain.Entities.Customers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Domain.Entities.Adminstrators;

public class Chat
{
    [Key]
    public int ID { get; set; }

    [Required]
    [StringLength(int.MaxValue)]
    public string? Text { get; set; }

    [Required]
    public DateTime Date { get; set; }

    [Required]
    public bool IsRead { get; set; }

    [Required]
    public char Sender { get; set; } // [C]ustomer, [A]dmin

    public static Chat Create(int id, string text, DateTime date, bool isread, char sender, 
        Customer customer, Administrator admin)
    {
        Chat chat = new Chat()
        {
            ID = id,
            Text = text,
            Date = date,
            Sender = sender,
            IsRead = isread,
            CustomerID = customer.ID,
            Customer = customer,
            AdministratorID = admin.ID,
            Administrator = admin,
        };

        return chat;
    }

    
    public int CustomerID { get; set; }
    public Customer? Customer { get; set; }

    public int AdministratorID { get; set; }
    public Administrator? Administrator { get; set; }

}