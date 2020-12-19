using IPA;
using SiraUtil;
using SiraUtil.Zenject;
using IPALogger = IPA.Logging.Logger;

namespace Maple
{
    [Plugin(RuntimeOptions.DynamicInit)]
    public class Plugin
    {
        [Init]
        public Plugin(IPALogger logger, Zenjector zenjector)
        {
            zenjector
                .On<PCAppInit>()
                .Pseudo(Container =>
                {
                    Container.BindLoggerAsSiraLogger(logger,
                        #if DEBUG
                        true
                        #else
                        false
                        #endif
                        );
                });
        }

        [OnEnable]
        public void OnEnable()
        {

        }

        [OnDisable]
        public void OnDisable()
        {

        }
    }
}