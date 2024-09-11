/**
 * v0 by Vercel.
 * @see https://v0.dev/t/g4TNUwcX6XS
 * Documentation: https://v0.dev/docs#integrating-generated-code-into-your-nextjs-app
 */
import { Separator } from "@/components/ui/separator"

export default function Component() {
  return (
    <div className="grid grid-cols-1 md:grid-cols-2 gap-8 p-8">
      <div className="bg-background rounded-lg shadow-lg">
        <div className="p-6">
          <div className="flex items-center justify-between">
            <h2 className="text-2xl font-bold">Weather</h2>
            <div className="flex items-center gap-2">
              <LocateIcon className="w-5 h-5 text-muted-foreground" />
              <span className="text-muted-foreground">San Francisco</span>
            </div>
          </div>
          <div className="grid grid-cols-2 gap-4 mt-6">
            <div className="flex flex-col items-center">
              <div className="text-6xl font-bold">72°</div>
              <div className="text-muted-foreground">Sunny</div>
            </div>
            <div className="flex flex-col items-center">
              <div className="text-4xl font-bold">H: 75° L: 65°</div>
              <div className="text-muted-foreground">Today</div>
            </div>
          </div>
          <Separator className="my-6" />
          <div className="grid grid-cols-3 gap-4">
            <div className="flex flex-col items-center">
              <div className="text-2xl font-bold">Mon</div>
              <div className="text-muted-foreground">70° / 60°</div>
            </div>
            <div className="flex flex-col items-center">
              <div className="text-2xl font-bold">Tue</div>
              <div className="text-muted-foreground">72° / 62°</div>
            </div>
            <div className="flex flex-col items-center">
              <div className="text-2xl font-bold">Wed</div>
              <div className="text-muted-foreground">74° / 64°</div>
            </div>
            <div className="flex flex-col items-center">
              <div className="text-2xl font-bold">Thu</div>
              <div className="text-muted-foreground">76° / 66°</div>
            </div>
            <div className="flex flex-col items-center">
              <div className="text-2xl font-bold">Fri</div>
              <div className="text-muted-foreground">78° / 68°</div>
            </div>
            <div className="flex flex-col items-center">
              <div className="text-2xl font-bold">Sat</div>
              <div className="text-muted-foreground">80° / 70°</div>
            </div>
          </div>
        </div>
      </div>
      <div className="bg-background rounded-lg shadow-lg">
        <div className="p-6">
          <h2 className="text-2xl font-bold">Google Maps</h2>
          <div className="mt-6 aspect-video rounded-lg overflow-hidden">
            <iframe
              src="https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3153.5928847703087!2d-122.41941568433837!3d37.77493297975112!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x80858080a8d2c9b9%3A0x5c256c85b474f8b2!2sSan%20Francisco%2C%20CA%2C%20USA!5e0!3m2!1sen!2sca!4v1684687200000!5m2!1sen!2sca"
              width="100%"
              height="100%"
              style={{ border: 0 }}
              allowFullScreen
              loading="lazy"
              referrerPolicy="no-referrer-when-downgrade"
            />
          </div>
        </div>
      </div>
    </div>
  )
}

function LocateIcon(props) {
  return (
    <svg
      {...props}
      xmlns="http://www.w3.org/2000/svg"
      width="24"
      height="24"
      viewBox="0 0 24 24"
      fill="none"
      stroke="currentColor"
      strokeWidth="2"
      strokeLinecap="round"
      strokeLinejoin="round"
    >
      <line x1="2" x2="5" y1="12" y2="12" />
      <line x1="19" x2="22" y1="12" y2="12" />
      <line x1="12" x2="12" y1="2" y2="5" />
      <line x1="12" x2="12" y1="19" y2="22" />
      <circle cx="12" cy="12" r="7" />
    </svg>
  )
}
/*

// import Image from "next/image";

// export default function Home() {
//   return (
//     <div className="grid grid-rows-[20px_1fr_20px] items-center justify-items-center min-h-screen p-8 pb-20 gap-16 sm:p-20 font-[family-name:var(--font-geist-sans)]">
//       <main className="flex flex-col gap-8 row-start-2 items-center sm:items-start">
//         <Image
//           className="dark:invert"
//           src="https://nextjs.org/icons/next.svg"NKNK
//           alt="Next.js logo"
//           width={180}
//           height={38}
//           priority
//         />
//         <ol className="list-inside list-decimal text-sm text-center sm:text-left font-[family-name:var(--font-geist-mono)]">
//           <li className="mb-2">
//             Get started by editing{" "}
//             <code className="bg-black/[.05] dark:bg-white/[.06] px-1 py-0.5 rounded font-semibold">
//               app/page.tsx
//             </code>
//             .
//           </li>
//           <li>Save and see your changes instantly.</li>
//         </ol>

//         <div className="flex gap-4 items-center flex-col sm:flex-row">
//           <a
//             className="rounded-full border border-solid border-transparent transition-colors flex items-center justify-center bg-foreground text-background gap-2 hover:bg-[#383838] dark:hover:bg-[#ccc] text-sm sm:text-base h-10 sm:h-12 px-4 sm:px-5"
//             href="https://vercel.com/new?utm_source=create-next-app&utm_medium=appdir-template-tw&utm_campaign=create-next-app"
//             target="_blank"
//             rel="noopener noreferrer"
//           >
//             <Image
//               className="dark:invert"
//               src="https://nextjs.org/icons/vercel.svg"
//               alt="Vercel logomark"
//               width={20}
//               height={20}
//             />
//             Deploy now
//           </a>
//           <a
//             className="rounded-full border border-solid border-black/[.08] dark:border-white/[.145] transition-colors flex items-center justify-center hover:bg-[#f2f2f2] dark:hover:bg-[#1a1a1a] hover:border-transparent text-sm sm:text-base h-10 sm:h-12 px-4 sm:px-5 sm:min-w-44"
//             href="https://nextjs.org/docs?utm_source=create-next-app&utm_medium=appdir-template-tw&utm_campaign=create-next-app"
//             target="_blank"
//             rel="noopener noreferrer"
//           >
//             Read our docs
//           </a>
//         </div>
//       </main>
//       <footer className="row-start-3 flex gap-6 flex-wrap items-center justify-center">
//         <a
//           className="flex items-center gap-2 hover:underline hover:underline-offset-4"
//           href="https://nextjs.org/learn?utm_source=create-next-app&utm_medium=appdir-template-tw&utm_campaign=create-next-app"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           <Image
//             aria-hidden
//             src="https://nextjs.org/icons/file.svg"
//             alt="File icon"
//             width={16}
//             height={16}
//           />
//           Learn
//         </a>
//         <a
//           className="flex items-center gap-2 hover:underline hover:underline-offset-4"
//           href="https://vercel.com/templates?framework=next.js&utm_source=create-next-app&utm_medium=appdir-template-tw&utm_campaign=create-next-app"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           <Image
//             aria-hidden
//             src="https://nextjs.org/icons/window.svg"
//             alt="Window icon"
//             width={16}
//             height={16}
//           />
//           Examples
//         </a>
//         <a
//           className="flex items-center gap-2 hover:underline hover:underline-offset-4"
//           href="https://nextjs.org?utm_source=create-next-app&utm_medium=appdir-template-tw&utm_campaign=create-next-app"
//           target="_blank"
//           rel="noopener noreferrer"
//         >
//           <Image
//             aria-hidden
//             src="https://nextjs.org/icons/globe.svg"
//             alt="Globe icon"
//             width={16}
//             height={16}
//           />
//           Go to nextjs.org →
//         </a>
//       </footer>
//     </div>
//   );
// }

*/