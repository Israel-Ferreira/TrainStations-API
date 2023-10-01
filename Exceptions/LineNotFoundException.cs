using System.Runtime.Serialization;

namespace TrainStationsAPI.Exceptions;


[Serializable()]
public class LineNotFoundException : Exception {
    
    protected LineNotFoundException() : base()
    {
    }
    
    public LineNotFoundException(int lineNumber) : base($"A Linha {lineNumber} não foi encontrada")
    {
    }
    
    protected LineNotFoundException(SerializationInfo info, StreamingContext ctx) : base(info, ctx)
    {
        
    }
}