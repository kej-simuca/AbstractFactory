using AbstractFactory;

namespace DisneyGameUnitTest
{
    public class DisneyCartoonTesting_LevelsUnitest1
    {
        [Fact]
        public void Level2_Snowwhite_Wicked_Creation()
        {
            //Arrange; create the obj 
            IDisneyFactory level1hero = new Level1_SnowWhite();

            // act executing
            IHero herocreate = level1hero.CreateHero();

            //assert if its null is wrong
            Assert.NotNull(herocreate);
            //Assert.Null(wickedcreate);
        }
    }

    public class DisneyCartoonTesting_LevelsUnitest2
    {
        [Fact]
        public void Level2_Anastasia_Wicked_Creation()
        {                
            //Arrange; create the obj 
            IDisneyFactory level2Wicked = new Level2_Anastasia();

            // act executing
            IWicked wickedcreate = level2Wicked.CreateWicked();

            //assert if its null is wrong
            Assert.NotNull(wickedcreate);
            //Assert.Null(wickedcreate);
        }
    }
    public class DisneyCartoonTesting_LevelsUnitest3
    {
        [Fact]
        public void Level3_WALLE_Weapon_Creation()
        {
                //Arrange; create the obj
                IDisneyFactory level3Weapon = new Level3_WallE();

                // act executing
                IWeapon weaponcreate = level3Weapon.CreateWeapon();

                //assert 
                Assert.NotNull(weaponcreate);
        }
    }
    public class DisneyCartoonTesting_LevelsUnitest4
    {
        [Fact]
        public void Level4_PeterPan_Place_Creation()
        {
                //Arrange; create the obj
                IDisneyFactory level4Place = new Level4_PeterPan();

                // act execute
                IPlace placecreate = level4Place.CreatePlace();

                //assert
                Assert.NotNull(placecreate);
        }
    }
    public class DisneyCartoonTesting_LevelsUnitest5
    {
        [Fact]
        public void Level5_Mulan_GameLevel_Initialize()
        {
                //this is to check weather gamelevel is successfully initialized
                //arrange creating the instance of L5Mulan 
                IDisneyFactory factory = new Level5_Mulan();
                //act creates the obj with factory as the parameter stimulates the starting of the gamelevel using L5M
                GameLevel gameLevel = new GameLevel(factory);
                //assert to verify it aint null
                Assert.NotNull(gameLevel);
        }
    }
}