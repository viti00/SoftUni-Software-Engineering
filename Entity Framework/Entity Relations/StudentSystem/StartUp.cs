using Microsoft.EntityFrameworkCore;
using P01_StudentSystem.Data;
using System;

namespace StudentSystem
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            StudentSystemContext context = new StudentSystemContext();

            //context.Database.Migrate();
            
        }
    }
}
