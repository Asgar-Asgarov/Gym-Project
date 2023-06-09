using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace ApiCrud.Data;

public static class ModelBuilderExtensions
{
    public static void Seed(this ModelBuilder builder)
    {
        var pwd = "P@$$word";
        var passwordHasher = new PasswordHasher<IdentityUser>();

        //Seed Roles
        var adminRole = new IdentityRole("Admin");
        adminRole.NormalizedName = adminRole.Name.ToUpper();

        var superAdminRole = new IdentityRole("SuperAdmin");
        superAdminRole.NormalizedName = superAdminRole.Name.ToUpper();

        var memberRole = new IdentityRole("Member");
        memberRole.NormalizedName = memberRole.Name.ToUpper();

        List<IdentityRole> roles = new List<IdentityRole>()
       {
        adminRole,
        superAdminRole,
        memberRole
       };

        builder.Entity<IdentityRole>().HasData(roles);


        //Seed Users 
        var adminUser = new IdentityUser
        {
            UserName = "Asgar@gmail.com",
            Email = "Asgar@gmail.com",
            EmailConfirmed = true
        };
        adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
        adminUser.NormalizedEmail = adminUser.Email.ToUpper();
        adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, pwd);



        var SuperadminUser = new IdentityUser
        {
            UserName = "A.Asgar@gmail.com",
            Email = "A.Asgar@gmail.com",
            EmailConfirmed = true
        };
        SuperadminUser.NormalizedUserName = SuperadminUser.UserName.ToUpper();
        SuperadminUser.NormalizedEmail = SuperadminUser.Email.ToUpper();
        SuperadminUser.PasswordHash = passwordHasher.HashPassword(SuperadminUser, pwd);



        var MemberUser = new IdentityUser
        {
            UserName = "A.Asgar@gmail.com",
            Email = "A.Asgar@gmail.com",
            EmailConfirmed = true
        };
        MemberUser.NormalizedUserName = MemberUser.UserName.ToUpper();
        MemberUser.NormalizedEmail = MemberUser.Email.ToUpper();
        MemberUser.PasswordHash = passwordHasher.HashPassword(MemberUser, pwd);

        List<IdentityUser> users = new List<IdentityUser>()
       {
        adminUser,
        SuperadminUser,
        MemberUser
       };

        builder.Entity<IdentityUser>().HasData(users);

        //Seed UserRoles
    //     List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

    //     userRoles.Add(new IdentityUserRole<string>
    //     {
    //         UserId = users[0].Id,
    //         RoleId = roles.First(q => q.Name == "Admin").Id
    //     });


    //     userRoles.Add(new IdentityUserRole<string>
    //     {
    //         UserId = users[1].Id,
    //         RoleId = roles.First(q => q.Name == "SuperAdmin").Id
    //     });


    //     userRoles.Add(new IdentityUserRole<string>
    //     {
    //         UserId = users[2].Id,
    //         RoleId = roles.First(q => q.Name == "Member").Id
    //     });


    //    builder.Entity<IdentityUserRole<string>>().HasData(userRoles);

    }



}


