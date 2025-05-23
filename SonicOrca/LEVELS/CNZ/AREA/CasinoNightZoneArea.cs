﻿// Decompiled with JetBrains decompiler
// Type: SONICORCA.LEVELS.CNZ.AREA.CasinoNightZoneArea
// Assembly: S2HD, Version=2.0.1012.10521, Culture=neutral, PublicKeyToken=null
// MVID: 18631A0F-16CF-4E18-8563-1EC5E54750D6
// Assembly location: C:\Games\S2HD_2.0.1012-rc2\S2HD.exe

using SonicOrca;
using SonicOrca.Core;
using SonicOrca.Resources;
using System.Collections.Generic;
using System.Linq;

namespace SONICORCA.LEVELS.CNZ.AREA
{

    public class CasinoNightZoneArea : Area
    {
        private const string TileSetResourceKey = "//TILESET";
        private const string MapResourceKey = "//MAP";
        private const string BindingResourceKey = "//BINDING";
        private const string LevelMusicResourceKey = "SONICORCA/MUSIC/LEVELS/CNZ/COOPERATIVE";
        public static IReadOnlyList<string> AreaDependencies = (IReadOnlyList<string>)((IEnumerable<string>)new string[3]
        {
            "//TILESET",
            "//MAP",
            "//BINDING"
        }).ToArray<string>();
        private SonicOrcaGameContext _gameContext;
        private ResourceTree _resourceTree;
        private Level _level;

        public CasinoNightZoneArea()
          : base((IEnumerable<string>)CasinoNightZoneArea.AreaDependencies)
        {
        }

        public override void Prepare(Level level, LevelPrepareSettings settings)
        {
            this._gameContext = level.GameContext;
            this._resourceTree = this._gameContext.ResourceTree;
            this._level = level;
            this._level.Name = "Casino Night";
            this._level.ShowAsZone = true;
            this._level.ShowAsAct = true;
            this._level.Scheme = LevelScheme.S2;
            if (!settings.Seamless)
            {
                this._level.TileSet = this._resourceTree.GetLoadedResource<TileSet>((ILoadedResource)this, "//TILESET");
                this._level.LoadMap(this._resourceTree.GetLoadedResource<LevelMap>((ILoadedResource)this, "//MAP"));
                this._level.LoadBinding(this._resourceTree.GetLoadedResource<LevelBinding>((ILoadedResource)this, "//BINDING"));
            }
            this._level.Bounds = this._level.Map.Bounds;
        }
    }
}