﻿using System;
using System.Collections.Generic;
using System.Linq;
using Grabacr07.KanColleWrapper.Models;
using Livet;

namespace BattleInfoPlugin.Models
{
    public class ShipSlotData : NotificationObject
    {
        public SlotItemInfo Source { get; private set; }

        public int Maximum { get; private set; }

        public bool Equipped => this.Source != null;

        #region Current 変更通知プロパティ

        private int _Current;

        public int Current
        {
            get { return this._Current; }
            set
            {
                if (this._Current == value) return;
                this._Current = value;
                this.RaisePropertyChanged();
            }
        }

        #endregion

        public int Firepower { get; set; }
        public int Torpedo { get; set; }
        public int AA { get; set; }
        public int Armer { get; set; }
        public int Bomb { get; set; }
        public int ASW { get; set; }
        public int Hit { get; set; }
        public int Evade { get; set; }
        public int LOS { get; set; }

        public Type2 Type2 { get; set; }

        public string ToolTip => (this.Firepower != 0 ? "火力:" + this.Firepower : "")
                                 + (this.Torpedo != 0 ? " 雷装:" + this.Torpedo : "")
                                 + (this.AA != 0 ? " 対空:" + this.AA : "")
                                 + (this.Armer != 0 ? " 装甲:" + this.Armer : "")
                                 + (this.Bomb != 0 ? " 爆装:" + this.Bomb : "")
                                 + (this.ASW != 0 ? " 対潜:" + this.ASW : "")
                                 + (this.Hit != 0 ? " 命中:" + this.Hit : "")
                                 + (this.Evade != 0 ? " 回避:" + this.Evade : "")
                                 + (this.LOS != 0 ? " 索敵:" + this.LOS : "");

        public ShipSlotData(SlotItemInfo item, int maximum = -1, int current = -1)
        {
            this.Source = item;
            this.Maximum = maximum;
            this._Current = current;

            if (item == null || item == SlotItemInfo.Dummy) return;

            this.Armer = item.Armer;
            this.Firepower = item.Firepower;
            this.Torpedo = item.Torpedo;
            this.Bomb = item.Bomb;
            this.AA = item.AA;
            this.ASW = item.ASW;
            this.Hit = item.Hit;
            this.Evade = item.Evade;
            this.LOS = item.RawData.api_saku;
            this.Type2 = (Type2)item.RawData.api_type[1];
        }

        public ShipSlotData(ShipSlot slot)
            : this(slot.Item?.Info, slot.Maximum, slot.Current)
        {
        }
    }
}
