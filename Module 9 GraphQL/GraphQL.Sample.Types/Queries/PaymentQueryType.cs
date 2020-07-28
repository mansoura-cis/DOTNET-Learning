﻿using GraphQL.Sample.Database.Model;
using GraphQL.Types;

namespace GraphQL.Sample.Types
{
    public class PaymentQueryType : ObjectGraphType<Payment>
    {
        public PaymentQueryType()
        {
            Field(x => x.Id);
            Field(x => x.Value);
            Field(x => x.IssueDate);
            Field(x => x.OverDueDate);
            Field(x => x.IsPaid);
        }
    }
}
