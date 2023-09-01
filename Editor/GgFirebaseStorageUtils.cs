using GreenGrey.FirebaseStorage;
using UnityEditor;

#if UNITY_EDITOR
namespace GGFirebaseStorage.Editor
{
    /// <summary>
    /// Статические утилиты для упрощения работы в эдиторе
    /// </summary>
    public static class GgFirebaseStorageUtils
    {
        /// <summary>
        /// Удаляет пользователя в эдиторе
        /// </summary>
        [MenuItem("GreenGrey/FirebaseStorage/DeleteCurrentUser")]
        public static async void DeleteCurrentUser()
        {
            await GgFirebaseStorage.DeleteCurrentUser();
        }
    }
}
#endif