﻿using GalileuszSchool.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GalileuszSchool.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new GalileuszSchoolContext(serviceProvider.GetRequiredService<DbContextOptions<GalileuszSchoolContext>>()))
            {
                //context.Database.EnsureCreated();
                //if (context.LessonPlan.Any())
                //{
                //    return;
                //}

                //LessonPlan[] lessonPlanSlot = new LessonPlan[23];
                //for (int i = 0; i < 23;)
                //{
                //    lessonPlanSlot[i] = new LessonPlan {};
                //    i++;
                //    }
                //context.LessonPlan.AddRange(lessonPlanSlot);
                //context.SaveChanges();









                if (context.Pages.Any())
                {
                    return;
                }
                context.Pages.AddRange(
                    new Page
                    {
                        Title = "Home",
                        Slug = "home",
                        Content = "home page",
                        Sorting = 0
                    },
                    new Page
                    {
                        Title = "About Us",
                        Slug = "about-us",
                        Content = "about us page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Services",
                        Slug = "services",
                        Content = "services page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Title = "Contact",
                        Slug = "contact",
                        Content = "contact page",
                        Sorting = 100
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
