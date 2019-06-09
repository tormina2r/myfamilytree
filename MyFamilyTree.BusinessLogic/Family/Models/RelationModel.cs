namespace MyFamilyTree.BusinessLogic.Family.Models
{
    public class RelationModel
    {
        public RelationModel(int id, int source, int target, RelationType relationType)
        {
            Id = id;
            Source = source;
            Target = target;
            RelationType = relationType;
        }

        public int Id { get; }
        public int Source { get; }
        public int Target { get; }
        public RelationType RelationType { get; }
    }
}