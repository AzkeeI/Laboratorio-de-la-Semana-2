namespace MyFirstProyectWithLineCommand.Models
{
    public class BaseModel : EntityModel
    {
        public BaseModel()
        {
        }
        public Guid Id { get; set; }
        public DateTime FechaCreacion  { get; set; }

        public string NombreCarrer { get; set; }
        public string NombreCarrer2 { get; set; }
        
    }
}