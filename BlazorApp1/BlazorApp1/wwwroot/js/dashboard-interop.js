// wwwroot/js/dashboard-interop.js
window.dashboardInterop = {
    // 1. Invocado desde C#: copiar texto al portapapeles
    copiarPortapapeles: async function (texto) {
        try {
            await navigator.clipboard.writeText(texto);
            return true;
        } catch (err) {
            console.error("Error al acceder al portapapeles:", err);
            return false;
        }
    },

    // 2. Invocado desde C#: persistencia en LocalStorage
    guardarCursos: function (clave, json) {
        localStorage.setItem(clave, json);
    },

    leerCursos: function (clave) {
        return localStorage.getItem(clave);
    },

    // 3. Bidireccional (JS -> C#): escuchar eventos de red del navegador
    iniciarMonitorRed: function (dotNetHelper) {
        const reportarEstado = () => {
            const estaEnLinea = navigator.onLine;
            // Invoca el método de C# marcado con [JSInvokable]
            dotNetHelper.invokeMethodAsync('OnCambioEstadoRed', estaEnLinea);
        };

        window.addEventListener('online', reportarEstado);
        window.addEventListener('offline', reportarEstado);

        // Reporte inicial al cargar
        reportarEstado();
    }
};
