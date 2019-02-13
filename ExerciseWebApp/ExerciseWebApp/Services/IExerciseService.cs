using ExerciseWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExerciseWebApp.Services
{
    interface IExerciseService
    {
        IEnumerable<Image> GetImages();
    }
}
