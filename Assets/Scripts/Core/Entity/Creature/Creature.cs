﻿namespace Core
{
    public class Creature : Unit
    {
        internal override bool AutoScoped => true;

        public GridReference<Creature> GridRef { get; } = new GridReference<Creature>();

        public override void Accept(IUnitVisitor unitVisitor)
        {
            unitVisitor.Visit(this);
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}