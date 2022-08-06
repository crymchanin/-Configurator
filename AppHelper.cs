using Feodosiya.Lib.Conf;
using POFileManagerService.Configuration;


namespace Configurator {
    public static class AppHelper {

        public static ConfHelper ConfHelper { get; set; }
        public static Global Configuration { get; set; }

        public static bool IsSaved { get; set; }

        public static bool AdminPermisiions { get; set; }
    }
}
