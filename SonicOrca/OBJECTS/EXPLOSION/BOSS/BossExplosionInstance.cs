// Decompiled with JetBrains decompiler
// Type: SONICORCA.OBJECTS.EXPLOSION.BOSS.BossExplosionInstance
// Assembly: S2HD, Version=2.0.1012.10521, Culture=neutral, PublicKeyToken=null
// MVID: 18631A0F-16CF-4E18-8563-1EC5E54750D6
// Assembly location: C:\Games\S2HD_2.0.1012-rc2\S2HD.exe

using SonicOrca.Core;
using SonicOrca.Core.Objects.Base;
using SonicOrca.Extensions;

namespace SONICORCA.OBJECTS.EXPLOSION.BOSS
{

    public class BossExplosionInstance : ParticleObject
    {
      public BossExplosionInstance()
        : base("/ANIGROUP")
      {
      }

      protected override void OnStart()
      {
        base.OnStart();
        this.Level.SoundManager.PlaySound((IActiveObject) this, this.Type.GetAbsolutePath("SONICORCA/SOUND/BOSSEXPLOSION"));
        this.FilterMultiplier = 0.0;
      }
    }
}
