﻿namespace WriteTestableCode._2._SRP;

public class OrderValidator
{
    public void ThrowOnValidationFailed(OrderParameters orderParameters)
    {
        if (orderParameters.Number < 1 || orderParameters.Number > 30)
        {
            throw new ArgumentException($"Order {orderParameters.Number} of type {orderParameters.Type} seems incorrect");
        }
    }
}