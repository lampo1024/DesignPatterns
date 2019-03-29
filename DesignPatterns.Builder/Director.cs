using System;

namespace DesignPatterns.Builder
{
    public class Director
    {
        private IBuilder _builder;
        public void Construct(IBuilder builder)
        {
            _builder = builder;
            //_builder.StartUpOperations();
            //_builder.BuildBody();
            //_builder.InsertWheels();
            //_builder.AddHeadlights();
            //_builder.EndOperations();
            
            _builder
                .StartUpOperations()
                .BuildBody()
                .InsertWheels()
                .AddHeadlights()
                .EndOperations();
        }
    }
}
