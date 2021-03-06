﻿using Components;
using Nez;
using System.Collections.Generic;

namespace Systems {
    class MoveSystem : EntitySystem {
        public MoveSystem(Matcher matcher) : base(matcher) {
        }

        protected override void process(List<Entity> entities) {
            base.process(entities);
            foreach(Entity entity in entities) {
                MoveComponent moveComponent = entity.getComponent<MoveComponent>();
                if (moveComponent.targetPosition.HasValue) {
                    entity.position = moveComponent.targetPosition.Value;
                    moveComponent.targetPosition = null;
                }
            }
        }
    }
}
