using RoomNumber;

namespace RoomNumberTest
{
    public class roomNumberTest
    {
        private roomNumber _roomNumber { get; set; } = null;

        [SetUp]
        public void Setup()
        {
            _roomNumber = new roomNumber();
        }

        [Test]
        public void numberOfSets_EqualTest()
        {
            //asign
            var roomNbr = 122;
            //act
            var result = _roomNumber.numberOfSets(roomNbr);
            //assert
            Assert.AreEqual(2, result);
        }
        [Test]
        public void numberOfSets_NotEqualTest()
        {
            //asign
            var roomNbr = 888888;
            //act
            var result = _roomNumber.numberOfSets(roomNbr);
            //assert
            Assert.AreNotEqual(2, result);
        }
    }
}