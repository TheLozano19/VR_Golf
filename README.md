My First VR: What the $%VR? - Iteración 02

Descripción del Proyecto

Este proyecto es una experiencia interactiva de Realidad Virtual (VR) desarrollada en Unity, fuertemente inspirada en el espíritu experimental, creativo y absurdo del juego WHAT THE GOLF?.

La escena principal se compone de un archipiélago de islas flotantes cuidadosamente diseñadas, donde se combinan dinámicas de golf y boliche con un sistema avanzado de físicas. El entorno invita al usuario a experimentar con interacciones en realidad virtual, resolviendo retos a través de mecánicas inesperadas y el uso de diferentes configuraciones de gravedad.

Instrucciones para abrir y ejecutar el proyecto

Requisitos previos

Unity Hub instalado.

Versión de Unity compatible con el proyecto (revisar la versión exacta con la que se guardó el proyecto).

Visor Meta Quest (opcional pero recomendado) configurado con Quest Link.

Meta XR Core SDK / Meta Building Blocks (ya integrados en el proyecto).

Pasos de ejecución

Abrir en Unity:

Abre Unity Hub y selecciona "Add" (Añadir) o "Open" (Abrir).

Navega hasta la carpeta del repositorio clonado y selecciónala.

Espera a que Unity importe todos los assets y librerías necesarias.

Cargar la escena principal:

En la ventana Project, dirígete a la carpeta Assets/Scenes (o la ruta donde guardaste tu escena final).

Haz doble clic en la escena principal del proyecto para cargarla en la jerarquía.

Ejecutar la experiencia:

Con visor (Recomendado): Conecta tu visor Meta Quest mediante cable Link o Air Link. Asegúrate de que la aplicación de escritorio de Meta esté activa y presiona el botón de Play en Unity.

Sin visor (Simulador): Si no cuentas con el visor conectado en el momento, el proyecto es compatible con el XR Device Simulator, permitiendo emular el movimiento de la cabeza y los controles directamente con el teclado y el ratón al presionar Play.

 Explicación de las Mecánicas Principales

El mundo interactivo está construido utilizando los Meta Building Blocks para garantizar una inmersión fluida. Las mecánicas centrales son:

Mecánica de Resortera (Slingshot):
Es el método de lanzamiento principal en la experiencia. Mediante los controles VR, el usuario puede interactuar con el sistema de resorte: al agarrar, arrastrar hacia atrás y soltar, se calcula la tensión y la dirección para aplicar la fuerza exacta a la pelota u objeto a lanzar. Todo el comportamiento responde a los principios de simulación física y colisiones calculadas en tiempo real.

Manipulación de Gravedades y Físicas:
No todos los objetos se comportan igual. Se han implementado diferentes pelotas (basadas en la iteración pasada) que poseen ajustes únicos en sus componentes de Rigidbody. Al lanzarlas, el usuario experimentará cómo distintos valores de masa y escalas de gravedad alteran drásticamente el movimiento, el impacto y la trayectoria del objeto, transformando la física en un pilar fundamental del gameplay.

Interacción VR Directa (Grab & Interact):
Gracias a la configuración de colliders y componentes de interacción (XR Grab Interactables / Meta Blocks), el usuario puede interactuar directamente con elementos clave del entorno, como palos de golf o componentes de la pista de boliche y las islas, logrando una sensación de presencia total en el mundo virtual.
