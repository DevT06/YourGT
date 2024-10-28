﻿using YourGT.Shared.Entities;

namespace YourGT.Shared.Entities;

public class Grade
{
    public int Id { get; set; }
    public byte Value { get; set; }



    public string Description { get; set; }

    public DateTime CreatedAt { get; set;}

    #region Relations

    public Subject Subject { get; set; }
    public int SubjectId { get; set; }

    public Weight Weight { get; set; }
    public int WeightId { get; set; }

    #endregion
}