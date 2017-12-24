using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TaBILModLoader;
using ZX;

namespace TaBILTrainer
{
    public class TrainerMod : ModBase
    {
        public TrainerForm TrainerForm { get; private set; }

        public override void Init()
        {

        }

        public override void OnGameLoaded()
        {
            Log.Out("Trainermod Loaded");
            TrainerForm = new TrainerForm();
            TrainerForm.Show();
        }

        public override void OnUpdate()
        {
            if (ZXLevelState.Current != null)
            {
                TrainerForm.UpdateResource("gold", ZXLevelState.Current.Gold.ToString());
                TrainerForm.UpdateResource("wood", ZXLevelState.Current.Wood.ToString());
                TrainerForm.UpdateResource("stone", ZXLevelState.Current.Stone.ToString());
                TrainerForm.UpdateResource("iron", ZXLevelState.Current.Iron.ToString());
                TrainerForm.UpdateResource("oil", ZXLevelState.Current.Oil.ToString());
            }
            else
            {
                TrainerForm.UpdateResource("gold", "-");
                TrainerForm.UpdateResource("wood", "-");
                TrainerForm.UpdateResource("stone", "-");
                TrainerForm.UpdateResource("iron", "-");
                TrainerForm.UpdateResource("oil", "-");
            }
        }
    }
}