using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tictactoe {
  class Data {
    public const string BUTTON_NAME = "button";
    public const int BINGO_NUMBER = 3;
    
    public static readonly Dictionary<BUTTON_STATE, string> buttonStateSign = new Dictionary<BUTTON_STATE, string>() {
      {BUTTON_STATE.CIRCLE, "○"},
      {BUTTON_STATE.CROSS, "×"},
    };
    
    public static Dictionary<int, List<BODER_STATUS>> _boderStasusList = new Dictionary<int, List<BODER_STATUS>>() {
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_FRONT, BODER_STATUS.SLASH_FRONT, BODER_STATUS.WIDHT_FRONT}}
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_MIDDLE, BODER_STATUS.WIDHT_FRONT}}
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_BACK, BODER_STATUS.SLASH_BACK, BODER_STATUS.WIDHT_FRONT}}
      
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_FRONT, BODER_STATUS.WIDHT_MIDDLE}}
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_MIDDLE, BODER_STATUS.SLASH_FRONT, BODER_STATUS.WIDHT_MIDDLE}}
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_MIDDLE, BODER_STATUS.WIDHT_BACK}}
      
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_FRONT, BODER_STATUS.SLASH_BACK, BODER_STATUS.WIDHT_BACK}}
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_MIDDLE, BODER_STATUS.WIDHT_BACK}}
      {0, new List<BODER_STATUS>() { BODER_STATUS.HIGHT_BACK, BODER_STATUS.SLASH_FRONT, BODER_STATUS.WIDHT_BACK}}
    };
  }
}
