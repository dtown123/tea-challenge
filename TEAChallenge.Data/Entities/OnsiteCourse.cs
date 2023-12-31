﻿namespace TEAChallenge.Data.Entities;

public class OnsiteCourse
{
    public int CourseId { get; set; }

    public string Location { get; set; } = null!;

    public string Days { get; set; } = null!;

    public TimeSpan Time { get; set; }

    public virtual Course Course { get; set; } = null!;
}
