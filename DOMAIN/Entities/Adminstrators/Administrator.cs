﻿
using Domain.Helpers.Entities;
using Domain.Entities.Customers;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities.Adminstrators;

public class Administrator : IAggregateRoot
{
    
    [Key]
    public int ID { get; set; }

    [Required]
    public string? FullName { get; set; }

    [Required]
    public string? Email { get; set; }

    [Required]
    public byte[]? PasswordHash { get; set; }

    [Required]
    public byte[]? PasswordSalt { get; set; }


    public static Administrator Create(int id, string fullname, string email, byte[] hash, byte[] salt, int avatarid)
    {
        Administrator admin = new Administrator()
        {
            ID = id,
            FullName = fullname,
            Email = email,
            PasswordHash = hash,
            PasswordSalt = salt,
            AvatarID = avatarid
        };

        return admin;
    }


    public List<Chat>? Chats { get; set; }


    public int AvatarID { get; set; }
    public Avatar? Avatar { get; set; }


}
