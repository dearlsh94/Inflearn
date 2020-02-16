using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using ProjectNC01.Models;

namespace ProjectNC01.Data
{
    public class DbSeeder
    {
        private readonly ProjectNC01Context _context;
        public readonly UserManager<ApplicationUser> _userManager;
        public readonly RoleManager<IdentityRole> _roleManager;
        
        public DbSeeder(ProjectNC01Context context,
                            UserManager<ApplicationUser> userManager,
                            RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        /*
        * async 는 Task와 함께 사용
        
        public async Task SeedDatabase()
        {
            if (true) //( !_context.Teachers.Any() )
            {
                List<TeacherModel> teachers = new List<TeacherModel>()
                {
                    new TeacherModel() { Name = "T1", Class = "C1" },
                    new TeacherModel() { Name = "T2", Class = "C2" },
                    new TeacherModel() { Name = "T3", Class = "C3" },
                    new TeacherModel() { Name = "T4", Class = "C4" }
                };
                */
                /*
                 * AddRangeAsync : List 형태의 데이터 Insert 일 경우
                 * AddAsync : 단일 데이터 Insert 일 경우
                 
                await _context.AddRangeAsync(teachers);
                await _context.SaveChangesAsync();
            }

            var adminAccount = await _userManager.FindByNameAsync("admin@gamil.com");
            var adminRole = new IdentityRole("Admin");
            await _roleManager.CreateAsync(adminRole);
            awiat _userManager.AddToRoleAsync(adminAccount, adminRole.Name);
        }
        */
    }
}