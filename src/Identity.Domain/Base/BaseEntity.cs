﻿namespace Identity.Domain.Base
{
    public class BaseEntity
    {
        public long Id { get; protected set; }
        public DateTime CreationDate { get; private set;}

        public BaseEntity()
        {
            CreationDate = new DateTime();
        }
    }
}