using Kanbanize.DTOs.Boards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kanbanize.Builders
{
    public class BoardBuilder
    {
        private Board _board;

        public BoardBuilder()
        {
            _board = new Board();
        }
        public BoardBuilder DefaultBoard()
        {
            _board = new Board();
            _board.boardid = "2";
            return this;
        }
        public Board Build()
        {
            return _board;
        }
    }
}
