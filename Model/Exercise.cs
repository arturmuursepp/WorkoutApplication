using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WorkoutApplication.Model
{
    public class Exercise
    {
        public int Id { get; init; }
        public string? Title { get; init; }
        public string? Description { get; init; }
        public ExerciseIntensity Intensity { get; init; }
        public int RecommendedDurationInSeconds { get; init; }
        public int RecommendedDurationInSecondsBeforeExercise { get; init; }
        public int RecommendedDurationInSecondsAfterExercise { get; init; }
        public string? RestTimeInstructions { get; init; }
        
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public enum ExerciseIntensity{
            Low = 1,
            Normal = 2,
            High = 3
        }
    }
}