namespace DungeonLibrary
{
    public class Character
    {
        private int _life;

        public string Name { get; set; }

        public int HitChance { get; set; }

        public int Block { get; set; }

        public int MaxLife { get; set; }

        public int Life
        {
            get { return _life; }
            set
            {
                if (value >= MaxLife)
                {
                    value = MaxLife;
                }
                else
                {
                    value = _life;
                }

            }


        }

        public Character()
        {
            
        }

        public Character(string name, int hitChance, int block, int maxLife, int life)
        {
            Name = name;
            HitChance = hitChance;
            Block = block;
            MaxLife = maxLife;
            Life = life;
        }

        public virtual int CalcBlock()
        {
            return Block;
        }

        public virtual int CalcHitChance()
        {
            return HitChance;
        }

        public virtual int CalcDamage()
        {
            return 0;
        }

        public override string ToString()
        {
            return string.Format("Name: {0}\n" +
                "Max Life: {1}\n" +
                "Life: {2}\n" +
                "Block: {3}\n" +
                "Hit Chance: {4}",
                Name,
                MaxLife,
                Life,
                Block,
                HitChance);
        }

    }

}