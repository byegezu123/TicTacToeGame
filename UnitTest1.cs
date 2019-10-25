using NUnit.Framework;
using TicTacToe;

namespace TicTacToeTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void testCreateBoard()
        {
            TicTacToeGame game = new TicTacToeGame();
            game.createBoard();
            Assert.AreEqual(9, game.board.Length);
        }

        [Test]
        public void testCurrentPlayerX()
        {
            TicTacToeGame game = new TicTacToeGame();
            Assert.AreEqual("x", game.currentPlayer());
        }

        [Test]
        public void testchangePlayerX()
        {
            TicTacToeGame game = new TicTacToeGame();
            game.changeplayer();
            Assert.AreEqual("x", game.changePlayer());
        }

        [Test]
        public void testmakemove()
        {
            TicTacToeGame game = new TicTacToeGame();
            game.makemove();
            Assert.AreEqual("x", game.makemove);
        }

        [Test]
        public void testspaceinuse()
        {
            TicTacToeGame game = new TicTacToeGame();
            game.spaceinuse();
            Assert.AreEqual("-", game.spaceinuse);
        }
    }
}