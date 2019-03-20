namespace Mined_Out {
    public abstract class InventoryItem {
        public char Icon {protected set; get;}
        public string Type {protected set; get;} 
        public int ChanceToSpawn {protected set; get;}
        public abstract bool Activate(Field f);
    }
}