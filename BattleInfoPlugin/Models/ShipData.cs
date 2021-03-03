﻿using System;
using System.Collections.Generic;
using System.Linq;
using Grabacr07.KanColleWrapper.Models;
using Livet;

namespace BattleInfoPlugin.Models
{
    public abstract class ShipData : NotificationObject
    {

        #region Id変更通知プロパティ
        private int _Id;

        public int Id
        {
            get { return this._Id; }
            set
            {
                if (this._Id != value)
                {
                    this._Id = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region Name変更通知プロパティ
        private string _Name;

        public string Name
        {
            get { return this._Name; }
            set
            {
                if (this._Name != value)
                {
                    this._Name = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region AdditionalName変更通知プロパティ
        private string _AdditionalName;

        public string AdditionalName
        {
            get { return this._AdditionalName; }
            set
            {
                if (this._AdditionalName != value)
                {
                    this._AdditionalName = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region TypeName変更通知プロパティ
        private string _TypeName;

        public string TypeName
        {
            get { return this._TypeName; }
            set
            {
                if (this._TypeName != value)
                {
                    this._TypeName = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region Level変更通知プロパティ
        private int _Level;
        public int Level
        {
            get { return this._Level; }
            set
            {
                if (this._Level != value)
                {
                    this._Level = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region Situation変更通知プロパティ
        private ShipSituation _Situation;

        public ShipSituation Situation
        {
            get { return this._Situation; }
            set
            {
                if (this._Situation != value)
                {
                    this._Situation = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region MaxHP変更通知プロパティ
        private int _MaxHP;
        public int MaxHP
        {
            get { return this._MaxHP; }
            set
            {
                if (this._MaxHP == value)
                    return;
                this._MaxHP = value;
                this.RaisePropertyChanged();
                this.RaisePropertyChanged(nameof(this.HP));
            }
        }
        #endregion

        #region NowHP変更通知プロパティ
        private int _NowHP;
        public int NowHP
        {
            get { return this._NowHP; }
            set
            {
                value = Math.Max(0, value);
                if (this._NowHP != value)
                {
                    this._NowHP = value;
                    this.RaisePropertyChanged();
                    this.RaisePropertyChanged(nameof(this.HP));
                }
            }
        }
        #endregion

        public abstract int OriginalHP { get; }

        #region AttackDamage

        private int _AttackDamage;

        // stage3?
        public int AttackDamage
        {
            get { return this._AttackDamage; }
            internal set
            {
                if (this._AttackDamage != value)
                {
                    this._AttackDamage = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region DamageReceived

        private int _DamageReceived;

        public int DamageReceived
        {
            get { return this._DamageReceived; }
            private set
            {
                if (this._DamageReceived != value)
                {
                    this._DamageReceived = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region Firepower 変更通知プロパティ

        private int _Firepower;

        /// <summary>
        /// 火力ステータス値を取得します。
        /// </summary>
        public int Firepower
        {
            get { return this._Firepower; }
            set
            {
                if (this._Firepower != value)
                {
                    this._Firepower = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region Torpedo 変更通知プロパティ

        private int _Torpedo;

        /// <summary>
        /// 雷装ステータス値を取得します。
        /// </summary>
        public int Torpedo
        {
            get { return this._Torpedo; }
            set
            {
                if (this._Torpedo != value)
                {
                    this._Torpedo = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region AA 変更通知プロパティ

        private int _AA;

        /// <summary>
        /// 対空ステータス値を取得します。
        /// </summary>
        public int AA
        {
            get { return this._AA; }
            set
            {
                if (this._AA != value)
                {
                    this._AA = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region Armer 変更通知プロパティ

        private int _Armer;

        /// <summary>
        /// 装甲ステータス値を取得します。
        /// </summary>
        public int Armer
        {
            get { return this._Armer; }
            set
            {
                if (this._Armer != value)
                {
                    this._Armer = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region Luck 変更通知プロパティ

        private int _Luck;

        /// <summary>
        /// 運のステータス値を取得します。
        /// </summary>
        public int Luck
        {
            get { return this._Luck; }
            set
            {
                if (this._Luck != value)
                {
                    this._Luck = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region Slots変更通知プロパティ
        private IEnumerable<ShipSlotData> _Slots;

        public IEnumerable<ShipSlotData> Slots
        {
            get { return this._Slots; }
            set
            {
                if (this._Slots != value)
                {
                    this._Slots = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region ExSlot変更通知プロパティ
        private ShipSlotData _ExSlot;

        public ShipSlotData ExSlot
        {
            get { return this._ExSlot; }
            set
            {
                if (this._ExSlot != value)
                {
                    this._ExSlot = value;
                    this.RaisePropertyChanged();
                }
            }
        }
        #endregion

        #region IsUsedDamecon 変更通知プロパティ

        private bool _IsUsedDamecon;

        /// <summary>
        /// 運のステータス値を取得します。
        /// </summary>
        public bool IsUsedDamecon
        {
            get { return this._IsUsedDamecon; }
            set
            {
                if (this._IsUsedDamecon != value)
                {
                    this._IsUsedDamecon = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        #region IsMVP

        private bool _IsMVP;

        public bool IsMVP
        {
            get { return this._IsMVP; }
            set
            {
                if (this._IsMVP != value)
                {
                    this._IsMVP = value;
                    this.RaisePropertyChanged();
                }
            }
        }

        #endregion

        public virtual bool DamageControlled => this.Situation.HasFlag(ShipSituation.DamageControlled);

        public int SlotsFirepower => this.Slots.Sum(x => x.Firepower);
        public int SlotsTorpedo => this.Slots.Sum(x => x.Torpedo);
        public int SlotsAA => this.Slots.Sum(x => x.AA);
        public int SlotsArmer => this.Slots.Sum(x => x.Armer);
        public int SlotsASW => this.Slots.Sum(x => x.ASW);
        public int SlotsHit => this.Slots.Sum(x => x.Hit);
        public int SlotsEvade => this.Slots.Sum(x => x.Evade);

        public int SumFirepower => 0 < this.Firepower ? this.Firepower + this.SlotsFirepower : this.Firepower;
        public int SumTorpedo => 0 < this.Torpedo ? this.Torpedo + this.SlotsTorpedo : this.Torpedo;
        public int SumAA => 0 < this.AA ? this.AA + this.SlotsAA : this.AA;
        public int SumArmer => 0 < this.Armer ? this.Armer + this.SlotsArmer : this.Armer;

        public LimitedValue HP => new LimitedValue(NowHP, this.MaxHP, 0);

        public AttackType DayAttackType
            => this.HasScout() && this.Count(Type2.主砲) == 2 && this.Count(Type2.徹甲弾) == 1 ? AttackType.カットイン主主
            : this.HasScout() && this.Count(Type2.主砲) == 1 && this.Count(Type2.副砲) == 1 && this.Count(Type2.徹甲弾) == 1 ? AttackType.カットイン主徹
            : this.HasScout() && this.Count(Type2.主砲) == 1 && this.Count(Type2.副砲) == 1 && this.Count(Type2.電探) == 1 ? AttackType.カットイン主電
            : this.HasScout() && this.Count(Type2.主砲) >= 1 && this.Count(Type2.副砲) >= 1 ? AttackType.カットイン主副
            : this.HasScout() && this.Count(Type2.主砲) >= 2 ? AttackType.連撃
            : AttackType.通常;

        public AttackType NightAttackType
            => this.Count(Type2.魚雷) >= 2 ? AttackType.カットイン雷
            : this.Count(Type2.主砲) >= 3 ? AttackType.カットイン主主主
            : this.Count(Type2.主砲) == 2 && this.Count(Type2.副砲) >= 1 ? AttackType.カットイン主主副
            : this.Count(Type2.主砲) == 2 && this.Count(Type2.副砲) == 0 && this.Count(Type2.魚雷) == 1 ? AttackType.カットイン主雷
            : this.Count(Type2.主砲) == 1 && this.Count(Type2.魚雷) == 1 ? AttackType.カットイン主雷
            : this.Count(Type2.主砲) == 2 && this.Count(Type2.副砲) == 0 && this.Count(Type2.魚雷) == 0 ? AttackType.連撃
            : this.Count(Type2.主砲) == 1 && this.Count(Type2.副砲) >= 1 && this.Count(Type2.魚雷) == 0 ? AttackType.連撃
            : this.Count(Type2.主砲) == 0 && this.Count(Type2.副砲) >= 2 && this.Count(Type2.魚雷) <= 1 ? AttackType.連撃
            : AttackType.通常;

        public ShipData()
        {
            this._Name = "？？？";
            this._AdditionalName = "";
            this._TypeName = "？？？";
            this._Situation = ShipSituation.None;
            this._Slots = new ShipSlotData[0];
        }

        internal void ReceiveDamage(int damage)
        {
            this.NowHP -= damage;
            this.DamageReceived += damage;
        }
    }

    public static class ShipDataExtensions
    {
        public static int Count(this ShipData data, Type2 type2)
        {
            return data.Slots.Count(x => x.Type2 == type2);
        }

        public static bool HasScout(this ShipData data)
        {
            return data.Slots
                .Where(x => x.Source.Type == SlotItemType.水上偵察機
                            || x.Source.Type == SlotItemType.水上爆撃機)
                .Any(x => 0 < x.Current);
        }

        public static void CheckDamageControl(this ShipData ship)
        {
            if (ship.NowHP > 0) return;

            // ダメコンによる回復処理。同一戦闘で2度目が発生する事はないという前提……
            var damageControl = ship.FirstDamageControlOrNull();

            if (damageControl == null) return;

            ship.IsUsedDamecon = true;
            if (damageControl.IsDamecon())
            {
                ship.NowHP = (int)Math.Floor(ship.MaxHP * 0.2);
            }
            else
            {
                ship.NowHP = ship.MaxHP;
            }
        }

        private static bool IsDamecon(this ShipSlotData info)
        {
            return info?.Source?.Id == 42;
        }

        private static bool IsMegami(this ShipSlotData info)
        {
            return info?.Source?.Id == 43;
        }

        private static ShipSlotData FirstDamageControlOrNull(this ShipData ship)
        {
            // ダメコン優先度: 拡張スロット＞インデックス順
            if (ship.ExSlot.IsDamecon() || ship.ExSlot.IsMegami())
            {
                return ship.ExSlot;
            }
            return ship.Slots?.FirstOrDefault(x => x.IsDamecon() || x.IsMegami());
        }
    }

    public class MembersShipData : ShipData
    {

        #region Source変更通知プロパティ
        private Ship _Source;

        public Ship Source
        {
            get
            { return this._Source; }
            set
            {
                if (this._Source == value)
                    return;
                this._Source = value;
                this.RaisePropertyChanged();
                this.UpdateFromSource();
            }
        }
        #endregion

        public override int OriginalHP => this.Source?.HP.Current ?? 0;


        public MembersShipData()
        {
        }

        public MembersShipData(Ship ship)
        {
            this._Source = ship;
            this.UpdateFromSource();
        }

        private void UpdateFromSource()
        {
            this.Id = this.Source.Id;
            this.Name = this.Source.Info.Name;
            this.TypeName = this.Source.Info.ShipType.Name;
            this.Level = this.Source.Level;
            this.Situation = this.Source.Situation;
            this.NowHP = this.Source.HP.Current;
            this.MaxHP = this.Source.HP.Maximum;
            this.Slots = this.Source.Slots
                .Where(s => s != null)
                .Where(s => s.Equipped)
                .Select(s => new ShipSlotData(s)).ToArray();
            this.ExSlot = new ShipSlotData(this.Source.ExSlot);

            this.Firepower = this.Source.Firepower.Current;
            this.Torpedo = this.Source.Torpedo.Current;
            this.AA = this.Source.AA.Current;
            this.Armer = this.Source.Armer.Current;
            this.Luck = this.Source.Luck.Current;
        }
    }

    public class MastersShipData : ShipData
    {

        #region Source変更通知プロパティ
        private ShipInfo _Source;

        public ShipInfo Source
        {
            get
            { return this._Source; }
            set
            {
                if (this._Source == value)
                    return;
                this._Source = value;
                this.RaisePropertyChanged();
                this.UpdateFromSource();
            }
        }
        #endregion

        public override int OriginalHP => this.MaxHP;

        public override bool DamageControlled => false;

        public MastersShipData()
        {
        }

        public MastersShipData(ShipInfo info) : this()
        {
            this._Source = info;
            this.UpdateFromSource();
        }

        private void UpdateFromSource()
        {
            this.Id = this.Source.Id;
            this.Name = this.Source.Name;
            var isEnemyID = 1500 < this.Source.Id && this.Source.Id < 1901;
            this.AdditionalName = isEnemyID ? this.Source.RawData.api_yomi : "";
            this.TypeName = this.Source.ShipType.Name;
        }
    }
}
